using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Emails
{
    public interface IEmailService
    {
        Task SendAsync(string to, string subject, string body);
    }
}
