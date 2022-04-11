using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using System.Diagnostics;
using WebApplication8.Services.EmailService;
using WebApplication8.Services.SmsService;
using Mvc101.Services.SmsService;

namespace MVC101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISmsService _smsService;
        private readonly IEmailServices _emailService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IServiceProvider _serviceProvider;
        private int id;

        public HomeController(ISmsService smsService,
            IEmailServices emailService,
            IWebHostEnvironment appEnvironment,
            IServiceProvider serviceProvider)
        {
            _smsService = smsService;
            _emailService = emailService;
            _appEnvironment = appEnvironment;
            _serviceProvider = serviceProvider;

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

            IEmailServices emailServices;
            if (id % 2 == 0)
            {
                emailServices = (IEmailServices)_serviceProvider.GetService<SendGridEmailService>();
            }
            else
            {
                emailServices = (IEmailServices)_serviceProvider.GetService<OutlookEmailService>();
            }

            //var fileStream = new FileStream(@$"{_appEnvironment.WebRootPath}\files\images.jpg", FileMode.Open);
           
            _emailService.SendMailAsync(new MailModel()
            {
                To = new List<EmailModels>()
                {
                    new EmailModels()
                    {
                        Name = "Wissen",
                        Adress = "emrecanyasar1@outlook.com"
                    }
                },
                Subject = "Index Açıldı",
                Body = "Bu emailin body kısmıdır",
                //Attachs = new List<Stream>()
                //{
                //    fileStream
                //}
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