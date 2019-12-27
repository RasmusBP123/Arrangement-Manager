using MailKit.Net.Smtp;
using MimeKit;

namespace Group15.EventManager.ApplicationLayer.Email
{
    public interface IMailBuilder
    {
        MimeMessage CreateMailContent(MailboxAddress sender, MailboxAddress reciever);
        SmtpClient OpenSmtpServer();
    }
}
