using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sending_Emails_Demo.Dtos;
using Sending_Emails_Demo.Services;

namespace Sending_Emails_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaillingTestController : ControllerBase
    {
        private readonly IMailingService _mailingService;

        public MaillingTestController(IMailingService mailingService)
        {
            _mailingService = mailingService;
        }

        [HttpPost("Send")]

        public async Task<IActionResult> SendEmail([FromForm] MailReqDto dto)
        {
            await _mailingService.SendEmailAsync(dto.emailTo, dto.subject, dto.body, dto.attachment);
            return Ok();
        }
        
    }
}
