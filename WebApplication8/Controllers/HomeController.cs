using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using System.Diagnostics;
using WebApplication8.Services.EmailService;
using WebApplication8.Services.SmsService;

namespace MVC101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISmsService _smsService;
        private readonly IEmailServices _emailService;

        public HomeController(ISmsService smsService, IEmailServices emailService)
        {
            _smsService = smsService;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            var result = _smsService.Send(new SmsModel()
            {
                TelefonNo = "12345",
                Mesaj = "home/index çalıştı"
            });
            _emailService.SendMailAsync(new MailModel()
            {
                To = new List<EmailModels>()
                {
                    new EmailModels()
                    {
                        Name ="Wissen",
                        Adress = "fonece1702@nuesond.com"
                    },
                    new EmailModels()
                    {
                        Name ="Serkan",
                        Adress = "fonece1702@nuesond.com"
                    }
                },
                Subject = "Ah be Serkanım be ahh....",
                Body = ":rocket: Just for you :rocket: "
            });

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}