using System.Diagnostics;
using WebApplication8.Models;
using WebApplication8.Services.SmsService;

namespace Mvc101.Services.SmsService
{
    public class WissenSmsService : ISmsService
    {
        public string EndPoint { get; set; } = "https://wissenakademie.com";
        public SmsStates Send(SmsModel model)
        {
            Debug.WriteLine($"Wissen: {model.TelefonNo} - {model.Mesaj}");
            return SmsStates.Sent;
        }
    }
}