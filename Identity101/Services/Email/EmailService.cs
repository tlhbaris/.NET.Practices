using Identity101.Models;

namespace Identity101.Services.Email
{
    public interface EmailService
    {
        Task SendMailAsync(MailModel model);
    }
}
