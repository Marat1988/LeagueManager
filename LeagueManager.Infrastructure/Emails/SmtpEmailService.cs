using LeagueManager.Application.Emails;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;


namespace LeagueManager.Infrastructure.Emails
{
    public class SmtpEmailService : IEmailService
    {
        private readonly SmtpClient _client;
        private readonly string _from;

        public SmtpEmailService(IConfiguration configuration)
        {
            var settings = configuration.GetSection("Smtp");
            _from = settings["From"];
            _client = new SmtpClient
            {
                Host = settings["Host"],
                Port = int.Parse(settings["Port"]),
                Credentials = new NetworkCredential(
                    settings["UserName"],
                    settings["Password"]
                    ),
                EnableSsl = true
            };
        }

        public async Task SendAsync(string to, string subject, string body)
        {
            var message = new MailMessage(_from, to, subject, body)
            {
                IsBodyHtml = true
            };
            await _client.SendMailAsync(message);
        }
    }
}
