using System;
using System.Net.Mail;
using System.Net;


namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
          if(args.Length == 2)
            {
                DateTime localDate = DateTime.Now;
                SmtpClient smtp = new SmtpClient("taras181716@gmail.com");

              

                MailAddress from = new MailAddress("taras181716@gmail.com", "Taras");
                MailAddress to = new MailAddress(args[0]);
                MailMessage msg = new MailMessage(from, to);

                msg.Subject = args[1];
                msg.Body = "Lab-1 \n" + localDate.ToString("ua-UA") + localDate.Kind;
                smtp.Port = 25;
                smtp.Credentials = new NetworkCredential("taras181716@gmail.com", "Uevty.rNfhfc0702");
                smtp.EnableSsl = true;
                smtp.Send(msg);
            }
            else
            {
                Console.WriteLine("SYNTAX: task4.exe <FromAddr> <ToAddr>");
            }
        }

    }
}
