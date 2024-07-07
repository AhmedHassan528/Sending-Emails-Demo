using System.ComponentModel.DataAnnotations;

namespace Sending_Emails_Demo.Dtos
{
    public class MailReqDto
    {
        [Required]
        public string emailTo { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string body { get; set; }
        public IList<IFormFile>? attachment { get; set; }

    }
}
