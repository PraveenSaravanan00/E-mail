using E_mail.Model;

namespace E_mail.Data
{
    public interface IMailService
    {
        Task SendEmailAsync(mailrequest mailRequest);
    }
}
