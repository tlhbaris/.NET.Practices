using WebApplication8.Models;

namespace WebApplication8.Services.EmailService
{
    public interface IEmailServices
    {
        Task SendMailAsync(MailModel model);
    }
}
