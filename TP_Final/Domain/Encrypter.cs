using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public static class Encrypter
    {

        /// <summary> Encripta la contraseña </summary>
        /// <param string="pPassword"> Contraseña ingresada </param>
        /// <returns> String de la contraseña encriptada </returns>
        public static string Encrypt(string pPassword) 
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pPassword);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data).ToString();
        } 

    }
}
