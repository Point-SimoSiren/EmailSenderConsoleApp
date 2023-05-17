// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Mail;

Console.WriteLine("Anna vastaanottajan sähköpostiosoite:");
MailAddress to = new MailAddress(Console.ReadLine());


MailAddress from = new MailAddress("sirensimo7@gmail.com");

MailMessage email = new MailMessage(from, to);

email.Subject = "Testing out email sending";
email.Body = "Hello all the way from the land of C#";

SmtpClient smtp = new SmtpClient();
smtp.Host = "smtp.gmail.com";
smtp.Port = 465; // on SSL
smtp.Credentials = new NetworkCredential("sirensimo7@gmail.com", "koihpiu");
smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
smtp.EnableSsl = true;

try
{
    /* Send method called below is what will send off our email 
     * unless an exception is thrown.
     */
    smtp.Send(email);
}
catch (SmtpException ex)
{
    Console.WriteLine(ex.ToString());
}
