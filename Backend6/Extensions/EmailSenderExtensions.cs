using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Backend6.Services;

namespace Backend6.Services
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Подтвердите ваш адрес электронной почты",
                $"Пожалуйста, подтвердите свою учетную запись, нажав на эту ссылку: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
