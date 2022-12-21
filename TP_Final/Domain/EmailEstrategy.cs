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

        /// <summary> Notifica al usuario sobre el tiempo restante de su préstamo </summary>
        /// <param Loan="pLoan"> Contraseña ingresada </param>
        public void Notify(Loan pLoan)
        {
            TimeSpan pTiempoRestante = (pLoan.EndDate - DateTime.Now);
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("unabiblioprueba1@gmail.com", "Biblioteca Don Amancio", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add(pLoan.User.Email); //Correo destino?
            correo.Subject = "Correo de prueba"; //Asunto
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
                $"<h1 style =\"text-align: center;\"><span style=\"color: #ff0000;\">Biblioteca MILF</span></h1>" +
                $"<p> Hola<strong> {pLoan.User.Name} {pLoan.User.LastName}</strong>: !</p>" +
                $"<p> El motivo de este mensaje es para informar el estado de su préstamo realizado del libro <strong> {pLoan.Copy.Book.Title}</strong>: , al cual le quedan<strong> {pTiempoRestante.Days}</strong> días y <strong> {pTiempoRestante.Hours}</strong> horas para vencerse.</p>" +
                $"<p> Te recordamos que si no ha pasado el plazo de 15 días hábiles, usted puede renovar el préstamo del libro, lo cual le consumirá 5 puntos del puntaje por día de renovación.</p>" +
                $"<p> Te agradecemos por utilizar nuestro servicio.</p>" +
                $"<p> Saludos, Atte:</p>" +
                $"<p> Don Amancio</p>" +
                $"<p><img style =\"display: block; margin-left: auto; margin-right: auto;\" src=\"https://drive.google.com/file/d/1fxAsNeMfjuJGGpVvk1TFZS7PapC_wqGM/view?usp=sharing\" alt=\"\" width=\"253\" height=\"221\"/></p>" +
                $"<p> &nbsp;</p>  " +
                $"</body>" +
                $"</html>"; ;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("unabiblioprueba1@gmail.com", "hpwoczgpjijobjko");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);
            
        }
    }
}
