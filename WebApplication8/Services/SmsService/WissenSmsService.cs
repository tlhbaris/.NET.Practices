using System.Diagnostics;
using WebApplication8.Models;

namespace WebApplication8.Services.SmsService
{
    public class WissenSmsService : ISmsService
    {
        public SmsStates Send(SmsModel model)
        {
            Debug.Write(message: $"Wissen:{model.TelefonNo}-{model.Mesaj}");
            return SmsStates.Sent;
        }
    }
}
