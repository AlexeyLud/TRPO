using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TrPo
{
    public class EmailService
    {
        public async Task SendEmailAsync(string To, string From, MimeMessage emailMessage)
        {
            try
            {
                emailMessage.From.Add(new MailboxAddress("LookTo", From));
                emailMessage.To.Add(new MailboxAddress(To));

                using var client = new SmtpClient();
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync(From, "xw9Wmgea");
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
                Debug.WriteLine("Сообщение отправлено успешно!");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.GetBaseException().Message);
            }
        }
    }
}
