using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace gestao_condominio.Utils
{
    public class Email
    {
        public static void EnviaEmail()
        {
            MailMessage mail = new MailMessage("condquintas475@outlook.com", "umarcon@hotmail.com");
            SmtpClient client = new SmtpClient();

            client.EnableSsl = true;
            client.Host = "smtp-mail.outlook.com";
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("condquintas475@outlook.com", "duquedecaxias475");

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            mail.Subject = "teste";
            mail.Body = "teste2";

            client.Send(mail);
        }       
    }
}
