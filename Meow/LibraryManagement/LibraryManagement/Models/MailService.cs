using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class MailService
    {
        public static void SendMail(string toEmailString, string msg, string toName)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "libmanage2022@gmail.com",
                    Password = "meowmeow1548"
                }
            };

            MailAddress fromEmail = new MailAddress("libmanage2022@gmail.com", "Ban Quản Lý Thư Viện"); ;
            MailAddress toEmail = new MailAddress(toEmailString, toName);
            MailMessage message = new MailMessage()
            {
                From = fromEmail,
                Subject = "Phiếu mượn sách",
                Body = msg,
                IsBodyHtml = true,
                BodyEncoding = Encoding.UTF8,
            };

            message.To.Add(toEmail);
            client.Send(message);
        }
    }
}
