using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace VerifyEmailForgotPasswordWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly DataContext _context;
        public EmailController(DataContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> SendMailAsync(string email, string subject, string meassage)
        [HttpGet]
        public async Task<IActionResult> SendMailAsync()
        {
            //not working
            var mail = "admin@hhh.com";
            var password = "[2]hhhhh";
            var email = "fff@gmail.com";
            var subject = "Hi From Asp.net";
            var message = "Testing From ASP.net";  // Corrected typo in variable name

            using (var client = new SmtpClient("mail.fff.com", 465))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(mail, password);

                await client.SendMailAsync(new MailMessage(from: mail, to: email, subject, message));
            }

            return Ok("Email Sent successfully");
        }

    }
}
