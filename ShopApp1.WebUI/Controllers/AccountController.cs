using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopApp1.Business.Abstract;
using ShopApp1.WebUI.EmailService;
using ShopApp1.WebUI.Extensions;
using ShopApp1.WebUI.Identity;
using ShopApp1.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp1.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager; //cookie olaylarini eliyecek
        private IEmailSender _emailSender;
        private ICartService _cartService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;
        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //Post metodlarina yaziriq get ile gonderilen sorgu posta gelmirse burda bize xeta verecek 
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //var user = await _userManager.FindByNameAsync(model.UserName);
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Bu user adi ile daha evvel hesab yaranmayib");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Zehmet olmasa hesabiniza gelen link ile uzv oldugunuzu testiq edin ");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);  //3 cu parametr false olanda tarayici baglananda cookie silinir,4 cu hesab kilitlemek false eledik heleki
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");//eger nulla beraber deyilse esas seyfeye get Home/Index
            }
            ModelState.AddModelError("", "Girilen user adi ve ya sifre sehvdir");
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model) //Shopapp_123
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,  //Password hashlanacaq deye bura yazmiriq
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user); //usere gore token yaradir 
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                //email
                await _emailSender.SendEmailAsync(model.Email, "Hesabinizi testiq edin.", $"Zehmet olmasa email hesabinizi testiq elemek ucun linke <a href='https://localhost:44367{url}'> girin </a>");
                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("", "Bilinmeyen xeta oldu zehmet olmasa tekrar edin.");//eger identity xetasi vererse bu olacaq
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new AlertMessage()
            {
                Title = "Cixis edildi.",
                Message = "Cixis edildi.",
                AlertType = "warning"
            });
            return Redirect("~/");
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new AlertMessage()
                {
                    Title = "Lazmimsiz token.",
                    Message = "Lazmimsiz token.",
                    AlertType = "danger"
                });
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    //cart yaranacaq
                    _cartService.InitializeCart(user.Id);

                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Hesabiniz testiqlendi",
                        Message = "Hesabiniz testiqlendi",
                        AlertType = "success"
                    });
                    return View();
                }
            }
            TempData.Put("message", new AlertMessage()
            {
                Title = "Hesabiniz testiqlenmedi",
                Message = "Hesabiniz testiqlenmedi",
                AlertType = "warning"
            });
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }
            var user = await _userManager.FindByEmailAsync(Email);
            if (user == null)
            {
                return View();
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            //generate token
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });
            //email
            await _emailSender.SendEmailAsync(Email, "Reset Password", $"Sifrenizi yenilemek ucun linke <a href='https://localhost:44367{url}'> girin </a>");
            return View();
        }
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel { Token = token };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
