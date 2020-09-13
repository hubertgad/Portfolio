using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using System.Threading.Tasks;

namespace Portfolio.Email
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;

        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public async Task SendAsync(EmailModel model)
        {
            model.Status = Status.Sending;

            try
            {
                var message = new MimeMessage();
                message.To.Add(new MailboxAddress("Hubert Gad", "hubertgad@gmail.com"));
                message.From.Add(new MailboxAddress("no-reply@hubertgad.net"));
                message.Subject = model.Subject;
                message.Body = new TextPart(TextFormat.Html)
                {
                    Text = ("<b>Imię:</b> " + model.Name
                        + "<br/><b>Adres e-mail:</b> " + model.Email
                        + "<br /><b>Numer telefonu:</b> " + model.Phone
                        + "<br /><b>Wiadomość:</b> <br />" + model.Message).Replace("\n", "<br />")
                };

                using var emailClient = new SmtpClient();
                emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
                await emailClient.SendAsync(message);
                emailClient.Disconnect(true);
                model.Status = Status.Done;
            }
            catch
            {
                model.Status = Status.Error;
            }
        }
    }
}