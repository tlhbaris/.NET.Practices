using System.Diagnostics;
using WebApplication8.Models;
using WebApplication8.Services;

namespace WebApplication8.Services.SmsService
{
    public class SonicSmsService : ISmsService
    {
        public SmsStates Send(SmsModel model)
        {
            Debug.Write(message: $"Sonic:{model.TelefonNo}-{model.Mesaj}");
            return SmsStates.Sent;
        }
    }
}
