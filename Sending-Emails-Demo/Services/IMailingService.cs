using Microsoft.AspNetCore.Http;

namespace Sending_Emails_Demo.Services
{
    public interface IMailingService
    {
        Task SendEmailAsync(string emailTo, string subject, string body, IList<IFormFile>? attachment);
    }
}
