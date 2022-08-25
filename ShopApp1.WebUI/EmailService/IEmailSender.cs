using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp1.WebUI.EmailService
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string mail, string subject, string htmlMessage);
    }
}
