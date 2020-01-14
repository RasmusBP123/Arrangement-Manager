using Group15.EventManager.Application.ViewModels.Auth;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MimeKit;
using System;

namespace Group15.EventManager.ApplicationLayer.Email
{
    public class MailBuilder : IMailBuilder
    {
        private readonly IWebHostEnvironment _env;

        public MailBuilder(IWebHostEnvironment env)
        {
            _env = env;
        }
        public MimeMessage CreateMailContent(MailboxAddress sender, MailboxAddress receiver, UserModel model)
        {
            MimeMessage message = new MimeMessage();

            message.From.Add(sender);
            message.To.Add(receiver);
            message.Subject = "Køb af H.J. Hansen Vin";

            message.Body = CreateBody(model);

            return message;
        }

        public SmtpClient OpenSmtpServer()
        {
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.live.com", 587, false);
            client.Authenticate("rasmusvm6@hotmail.com", "num64bqe");

            return client;
        }

        public MimeEntity CreateBody(UserModel model)
        {
            BodyBuilder body = new BodyBuilder
            {
                HtmlBody = "<h1>Du har købt billet hos os</h1>" +
                $"Kære {model.FirstName}" +
                "<p>Du kan se dine billetter i ovenstående fil, vi glæder os til at se dig/Jer!</p>",
            };

            body.Attachments.Add(_env.ContentRootPath + "\\qr.png");

            return body.ToMessageBody();
        }
    }
}
