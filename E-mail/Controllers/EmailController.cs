using E_mail.Data;
using E_mail.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_mail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMailService mailService;
        public EmailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] mailrequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
