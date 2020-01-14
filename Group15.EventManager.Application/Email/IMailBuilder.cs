using Group15.EventManager.Application.ViewModels.Auth;
using MailKit.Net.Smtp;
using MimeKit;

namespace Group15.EventManager.ApplicationLayer.Email
{
    public interface IMailBuilder
    {
        MimeMessage CreateMailContent(MailboxAddress sender, MailboxAddress reciever, UserModel model);
        SmtpClient OpenSmtpServer();
    }
}
