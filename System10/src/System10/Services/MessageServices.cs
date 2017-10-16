using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using System;

namespace System10.Services
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link http://go.microsoft.com/fwlink/?LinkID=532713
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Ram", "ram@ram.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using (var client = new SmtpClient())
            {
                client.LocalDomain = "some.domain.com";
                await client.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
        public void SendEmail(string email, string subject, string message)
        {
            try
            {
                string FromAddress = "rpolneni_cntr@pomeroy.com";
                //string FromAddress = "ramchander1.net@gmail.com";
                string FromAdressTitle = "title";
                //To Address  
                string ToAddress = email;
                string ToAdressTitle = "Microsoft ASP.NET Core";
                string Subject = subject;
                string BodyContent = message;

                //Smtp Server  
                //string SmtpServer = "smtp.gmail.com";
                 string SmtpServer = "retail.smtp.com";
                //Smtp Port Number  
               // int SmtpPortNumber = 587;
                 int SmtpPortNumber = 465;


                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(FromAdressTitle, FromAddress));
                mimeMessage.To.Add(new MailboxAddress(ToAdressTitle, ToAddress));
                mimeMessage.Subject = Subject;
                mimeMessage.Body = new TextPart("plain")
                {
                    Text = BodyContent

                };

                using (var client = new SmtpClient())
                {

                    client.Connect(SmtpServer, SmtpPortNumber, false);
                    // Note: only needed if the SMTP server requires authentication  
                    // Error 5.5.1 Authentication   
                    client.Authenticate(FromAddress, "JF(a2mfp02");
                   // client.Authenticate(FromAddress, "chander@123");
                    client.Send(mimeMessage);
                    client.Disconnect(true);

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
