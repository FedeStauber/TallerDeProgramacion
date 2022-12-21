using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Web;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace TP_Final.Domain
{
    public class EmailEstrategy : INotificatorEstrategy
    {

        /* /// <summary> Notifica al usuario sobre el tiempo restante de su préstamo </summary>
         /// <param Loan="pLoan"> Contraseña ingresada </param>
         public void Notify(Loan pLoan)
         {
             TimeSpan pTiempoRestante = (pLoan.EndDate - DateTime.Now);
             MailMessage correo = new MailMessage();
             correo.From = new MailAddress("bibliotecadonamancio@gmail.com", "Biblioteca Don Amancio", System.Text.Encoding.UTF8);//Correo de salida
             correo.To.Add(pLoan.User.Email); //Correo destino?
             correo.Subject = "Vencimiento Cercano"; //Asunto
             correo.Body = $"" +
                 $"<!DOCTYPE html> " +
                 $"<html lang =\"es\"> " +
                 $"<head>" +
                 $"<meta charset =\"UTF-8\">" +
                 $"<meta http - equiv =\"X-UA-Compatible\" content=\"IE=edge\"> " +
                 $"<meta name =\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
                 $"<title> Document </title>" +
                 $"</head>" +
                 $"<body>" +
                 $"<h1 style =\"text-align: center;\"><span style=\"color: #ff0000;\">Biblioteca Don Amancio</span></h1>" +
                 $"<p> Hola<strong> {pLoan.User.Name} {pLoan.User.LastName}</strong>:</p>" +
                 $"<p> El motivo de este mensaje es para informar el estado de su préstamo realizado del libro <strong> {pLoan.Copy.Book.Title}</strong>, al cual le quedan<strong> {pTiempoRestante.Days}</strong> días y <strong> {pTiempoRestante.Hours}</strong> horas para vencerse.</p>" +
                 $"<p> Te recordamos que si no ha pasado el plazo de 15 días hábiles, usted puede renovar el préstamo del libro, lo cual le consumirá 5 puntos del puntaje por día de renovación.</p>" +
                 $"<p> Te agradecemos por utilizar nuestro servicio.</p>" +
                 $"<p> Saludos, Atte:</p>" +
                 $"<p> Don Amancio</p>" +
                 $"<p><img style =\"display: block; margin-left: auto; margin-right: auto;\" src=\"https://ibb.co/qjKCm7L\" alt =\"\" width=\"253\" height=\"221\"/></p>" +
                 $"<p> &nbsp;</p>  " +
                 $"</body>" +
                 $"</html>";
             correo.IsBodyHtml = true;
             correo.Priority = MailPriority.Normal;
             SmtpClient smtp = new SmtpClient();
             smtp.UseDefaultCredentials = false;
             smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
             smtp.Port = 25; //Puerto de salida
             smtp.Credentials = new System.Net.NetworkCredential("bibliotecadonamancio@gmail.com", "38570555");//Cuenta de correo
             ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
             smtp.EnableSsl = true;//True si el servidor de correo permite ssl
             smtp.Send(correo);*/
        
        public void Notify(Loan pLoan)
        {
            TimeSpan pTiempoRestante = (pLoan.EndDate - DateTime.Now);
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.From = new MailAddress("donamanciobiblioteca@hotmail.com", "Biblioteca Don Amancio", Encoding.UTF8);
            //Aquí ponemos el asunto del correo
            mail.Subject = "Tiene un préstamo próximo a vencer";
            //Aquí ponemos el mensaje que incluirá el correo
            mail.Body = $"" +
                 $"<!DOCTYPE html> " +
                 $"<html lang =\"es\"> " +
                 $"<head>" +
                 $"<meta charset =\"UTF-8\">" +
                 $"<meta http - equiv =\"X-UA-Compatible\" content=\"IE=edge\"> " +
                 $"<meta name =\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
                 $"<title> Document </title>" +
                 $"</head>" +
                 $"<body>" +
                 $"<h1 style =\"text-align: center;\"><span style=\"color: #ff0000;\">Biblioteca Don Amancio</span></h1>" +
                 $"<p> Hola<strong> {pLoan.User.Name} {pLoan.User.LastName}</strong>:</p>" +
                 $"<p> El motivo de este mensaje es para informar el estado de su préstamo realizado del libro <strong> {pLoan.Copy.Book.Title}</strong>, al cual le quedan<strong> {pTiempoRestante.Days}</strong> días y <strong> {pTiempoRestante.Hours}</strong> horas para vencerse.</p>" +
                 $"<p> Te recordamos que si no ha pasado el plazo de 15 días hábiles, usted puede renovar el préstamo del libro, lo cual le consumirá 5 puntos del puntaje por día de renovación.</p>" +
                 $"<p> Te agradecemos por utilizar nuestro servicio.</p>" +
                 $"<p> Saludos, Atte:</p>" +
                 $"<p> Don Amancio</p>" +
                 $"<p><img style =\"display: block; margin-left: auto; margin-right: auto;\" src=\"https://ibb.co/qjKCm7L\" alt =\"\" width=\"253\" height=\"221\"/></p>" +
                 $"<p> &nbsp;</p>  " +
                 $"</body>" +
                 $"</html>";
            //Especificamos a quien enviaremos el Email, no es necesario que sea Outlook, puede ser cualquier otro proveedor
            mail.To.Add(pLoan.User.Email);
            
            //Configuración SMTP
            SmtpClient smtpClient = new SmtpClient("smtp.live.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;            
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("donamanciobiblioteca@hotmail.com", "donamancio123", "smtp.live.com");
            smtpClient.Send(mail);
        }
    }
}
