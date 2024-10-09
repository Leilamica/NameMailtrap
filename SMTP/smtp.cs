using System.Net;
using System.Net.Mail;


namespace SMTP

{

    public class smtp
    {
        private readonly SmtpClient _smtpClient;

        public smtp()
        {
            _smtpClient = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("980f545379cb40", "17151a5d359a70"),
                EnableSsl = true
            };
        }

        public void SendEmail(string toEmail, string subject, string body)
        {
            var mailMessage = new MailMessage("leilamicacenita@gmail.com", toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            _smtpClient.Send(mailMessage);
            Console.WriteLine("Email sent to: " + toEmail);
        }
    }
}