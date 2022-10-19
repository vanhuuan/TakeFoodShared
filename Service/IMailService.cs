using TakeFoodShared.Model.Content;

namespace TakeFoodShared.Service;

public interface IMailService
{
    Task SendMail(MailContent mailContent);

    Task SendEmailAsync(string email, string subject, string htmlMessage);
}
