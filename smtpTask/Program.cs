using System;
using EASendMail;

namespace smtpTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpMail oMail = new SmtpMail("TryIt")
            {
                From = "sender@outlook.com",
                To = "receiver_email@gmail.com",
                Subject = "Hello World!",
                TextBody = "Hello, this is a test email sent using EASendMail."
            };
            SmtpClient oSmtp = new SmtpClient();

            SmtpServer oServer = new SmtpServer("smtp.office365.com")
            {
                User = "sender@outlook.com",
                Password = "password",
                Port = 587,
                ConnectType = SmtpConnectType.ConnectSSLAuto
            };
            try
            {
                Console.WriteLine("Email göndərilir...");
                oSmtp.SendMail(oServer, oMail);
                Console.WriteLine("Email uğurla göndərildi!");
            }
            catch (Exception ep)
            {
                Console.WriteLine("Xəta baş verdi:");
                Console.WriteLine(ep.Message);
            }
        }
    }
}


