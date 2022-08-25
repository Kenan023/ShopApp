using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopApp1.Business.Abstract;
using ShopApp1.Business.Concrete;
using ShopApp1.Data.Abstract;
using ShopApp1.Data.Concrete.EfCore;
using ShopApp1.WebUI.EmailService;
using ShopApp1.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp1.WebUI
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer("Server=DESKTOP-EIQOHNN\\SQLEXPRESS;Database=ShopApp1;Trusted_Connection=True;"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();//AddDefualtToken parol resetlemek yaradir

            services.Configure<IdentityOptions>(options =>
            { //passworda aid xusisuiyyetler
                options.Password.RequireDigit = true;//reqem olmalidir
                options.Password.RequireLowercase = true;//kicik herfler ola biler
                options.Password.RequireUppercase = true;//boyuk herf olmalidir
                options.Password.RequiredLength = 6;//minimum 6 olmalidir 
                options.Password.RequireNonAlphanumeric = true;//AlpaNumeric olsun yeni @ falan

                //Lockout-istifadeci hesabi baglanmasi
                options.Lockout.MaxFailedAccessAttempts = 5;//Max 5 defe sehv gire biler
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//5 deq sonra hesaba giris ede biler
                options.Lockout.AllowedForNewUsers = true;//Lockoutun aktiv olmasi ucun bunu etmeliyik

                //options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;//her istifadecinin ferqli mail addressi olmalidir true olanda
                options.SignIn.RequireConfirmedEmail = true;//Istifadeci sign in olur amma Emailden testiq elemelidir true olanda
                options.SignIn.RequireConfirmedPhoneNumber = false;//telefon ucunde testiq olmalidir true olanda 
            });

            services.ConfigureApplicationCookie(options =>
            {    //Cookie kullanicinin tarayicisinda uygulama terefden saxlanilan bilgisi
                options.LoginPath = "/account/login";//cookie vaxti bitibse onda bizi accountda logine gonderecek
                options.LogoutPath = "/account/logout";//cookie cixis olanda
                options.AccessDeniedPath = "/account/accessdenied";//login olan istifadeci sifaris vere biler amma admin seyfelerini gore bilmez
                options.SlidingExpiration = true;//default olaraq cookie vaxti 20 deq ,her istek eliyende 20 deq sifirlanir amma false etsek ferqi yoxdu 20 deq olan kimi silinecek
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); //default 20 di 60 oldu
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,//http telebi ile elave ede bilerik
                    Name = ".ShopApp1.Security.Cookie",
                    SameSite = SameSiteMode.Strict //csrf token,attacklara qarsi bunlari edirik

                };
            });

            services.AddScoped<IProductRepository, EfCoreProductRepository>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<ICartRepository, EfCoreCartRepository>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();

            services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
              new SmtpEmailSender(_configuration["EmailSender:Host"],
                              _configuration.GetValue<int>("EmailSender:Port"),
                              _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                              _configuration["EmailSender:UserName"],
                              _configuration["EmailSender:Password"])
            );

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            app.UseStaticFiles();//wwwroot folderdi acilir
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();//Data Layerde SeedDatabase cagrildi
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
               endpoints.MapControllerRoute(
               name: "checkout",
               pattern: "checkout",
               defaults: new { controller = "Cart", action = "Checkout" }
               );

                endpoints.MapControllerRoute(
               name: "cart",
               pattern: "cart",
               defaults: new { controller = "Cart", action = "UserList" }
               );

                endpoints.MapControllerRoute(
                 name: "adminusers",
                 pattern: "/admin/user/list",
                 defaults: new { controller = "Admin", action = "UserList" }
                 );
                endpoints.MapControllerRoute(
                name: "adminuseredit",
                pattern: "/admin/user/{id?}",
                defaults: new { controller = "Admin", action = "UserEdit" }
                 );
                endpoints.MapControllerRoute(
                  name: "adminroles",
                  pattern: "/admin/role/create",
                  defaults: new { controller = "Admin", action = "RoleCreate" }
                  );
                endpoints.MapControllerRoute(
                name: "adminroleedit",
                pattern: "/admin/role/{id?}",
                defaults: new { controller = "Admin", action = "RoleEdit" }
                );
                endpoints.MapControllerRoute(
                 name: "adminrolecreate",
                 pattern: "/admin/role/list",
                 defaults: new { controller = "Admin", action = "RoleList" }
                 );

                endpoints.MapControllerRoute(
                  name: "adminproducts",
                  pattern: "/admin/products",
                  defaults: new { controller = "Admin", action = "ProductList" }
                  );
                endpoints.MapControllerRoute(
                name: "adminproductcreate",
                pattern: "/admin/products/create",
                defaults: new { controller = "Admin", action = "ProductCreate" }
                 );
                endpoints.MapControllerRoute(
                 name: "adminproductedit",
                 pattern: "/admin/products/{id?}",
                 defaults: new { controller = "Admin", action = "ProductEdit" }
                 );
                endpoints.MapControllerRoute(
                name: "admincategories",
                pattern: "/admin/categories",
                defaults: new { controller = "Admin", action = "CategoryList" }
                );
                endpoints.MapControllerRoute(
                 name: "admincategorycreate",
                 pattern: "/admin/categories/create",
                 defaults: new { controller = "Admin", action = "CategoryCreate" }
                 );
                endpoints.MapControllerRoute(
                 name: "admincategoryedit",
                 pattern: "/admin/categories/{id?}",
                 defaults: new { controller = "Admin", action = "CategoryEdit" }
                 );
                endpoints.MapControllerRoute(
                  name: "adminproductlist",
                  pattern: "/admin/products",
                  defaults: new { controller = "Admin", action = "ProductList" }
                  );

                endpoints.MapControllerRoute(
                   name: "search",
                   pattern: "search",
                   defaults: new { controller = "Shop", action = "search" }
                   );
                endpoints.MapControllerRoute(
                    name: "productdetails",
                    pattern: "{url}",
                    defaults: new { controller = "Shop", action = "details" }
                    );
                endpoints.MapControllerRoute(
                    name: "products",
                    pattern: "products/{category?}",
                    defaults: new { controller = "Shop", action = "list" }
                    );
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}"
                   );
            });

            SeedIdentity.Seed(userManager, roleManager, configuration).Wait();//asenkron olduguna gore wait elave edirik
        }
    }
}
