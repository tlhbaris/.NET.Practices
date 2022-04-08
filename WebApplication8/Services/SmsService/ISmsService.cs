using WebApplication8.Models;

namespace WebApplication8.Services.SmsService
{
    public interface ISmsService
    {
        SmsStates Send(SmsModel model);
    }
}
