using System;
using System.Net.Mail;
using System.Net;


namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                MailAddress from = new MailAddress("taras181716@gmail.com", "Taras");
                MailAddress to = new MailAddress(args[0]);
                MailMessage msg = new MailMessage(from, to);

                msg.Subject = args[1];
                
                msg.Body = "<h1>Lab-1</h1>" + DateTime.Now;
                msg.IsBodyHtml = true;
                
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("taras181716@gmail.com", "lmijlgcmzlsqhsch");
                smtp.EnableSsl = true;
                smtp.Send(msg);
            }
            else
            {
                Console.WriteLine("HELP: task4.exe <FromAddr> <Theme>");
            }
        }

    }
}