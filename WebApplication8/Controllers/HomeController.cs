using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services.SmsService;
using System.Diagnostics;
using WebApplication8.Services.EmailService;
using WebApplication8.Services.SmsService;
using WebApplication8.Services.EmailService;
using Mvc101.Services.SmsService;

namespace Mvc101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISmsService _smsService;
        private readonly IEmailServices _emailService;
        private readonly IWebHostEnvironment _appEnvironment;

        public HomeController(ISmsService smsService, IEmailServices emailService, IWebHostEnvironment appEnvironment)
        {
            _smsService = smsService;
            _emailService = emailService;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            var result = _smsService.Send(new SmsModel()
            {
                TelefonNo = "12345",
                Mesaj = "home/index çalıştı"
            });

            var wissenSms = (WissenSmsService)_smsService;
            Debug.WriteLine(wissenSms.EndPoint);

            var fileStream = new FileStream(@$"{_appEnvironment.WebRootPath}\files\images.jpg", FileMode.Open);

            _emailService.SendMailAsync(new MailModel()
            {
                To = new List<EmailModels>()
                {
                    new EmailModels()
                    {
                        Name = "Wissen",
                        Adress = "site@wissenakademie.com"
                    }
                },
                Subject = "Index Açıldı",
                Body = "Bu emailin body kısmıdır",
                Attachs = new List<Stream>()
                {
                    fileStream
                }
            });

            return View();
        }

        public IActionResult Privacy()
        {
            var result = _smsService.Send(new SmsModel()
            {
                TelefonNo = "12345",
                Mesaj = "home/index çalıştı"
            });

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}