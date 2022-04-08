namespace WebApplication8.Models
{
    public class MailModel
    {
        public List<EmailModels> To { get; set; } = new();
        public List<EmailModels> Cc { get; set; } =new();
        public List<EmailModels> Bcc { get; set; } =new();
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<Stream> Attachs { get; set; }
    }
}
