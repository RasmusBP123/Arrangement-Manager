using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.Email;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/mail")]
    public class MailController : Controller
    {
        private readonly IMailBuilder _mailBuilder;
        private readonly IWebHostEnvironment _env;

        public MailController(IMailBuilder mailBuilder, IWebHostEnvironment env)
        {
            _mailBuilder = mailBuilder;
            _env = env;
        }

        [HttpPost]
        [Route("send/{to}")]
        public IActionResult SendEmail([FromRoute] string to, [FromBody] UserModel model)
        {
            MailboxAddress sender = new MailboxAddress("rasmusvm6@hotmail.com");
            MailboxAddress receiver = new MailboxAddress(to);

            var header = _mailBuilder.CreateMailContent(sender, receiver, model);
            var client = _mailBuilder.OpenSmtpServer();

            client.Send(header);
            client.Disconnect(true);
            client.Dispose();

            return Ok();
        }
    }
}