﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace TP_Final.Domain
{
    
    public class User
    {
        private string iPassword;        
        public User() {}       
        public int Id { get; set; }
        [Required]       
        public int DNI { get; set; }       
        [StringLength(150)]       
        public string Email { get; set; }
        public int Score { get; set; }
        public string Password { get { return iPassword; } set {this.iPassword = Encrypter.Encrypt(value); } }
        public string Name { get; set; }
        public string LastName  { get; set; }       
        public byte[] Avatar { get; set; }

        [Column("Admin")]
        public int _Admin { get; set; }
        [Column("Active")]
        public int _Active { get; set; }


        [NotMapped]       
        public bool Admin
        {
            get
            {
                if (_Admin == 0)
                    return false;
                else
                    return true;
            }
            set
            {
                if (value)
                    this._Admin = 1;
                else
                    this._Admin = 0;

            }
        }
        [NotMapped]
        public bool Active
        {
            get
            {
                if (_Active == 0)
                    return false;
                else
                    return true;
            }
            set
            {
                if (value)
                    this._Active = 1;
                else
                    this._Active = 0;
            }
        }

        /// <summary> Encripta la contraseña ingresada por el usuario en pantalla y la compara con la que posee. </summary>
        /// <param string="pPassword"> Contraseña ingresada </param>
        /// <returns> True si la contraseña es la misma, false si no lo es </returns>
        public bool PasswordMatch(string pPassword)
       {           
            if (this.Password == Encrypter.Encrypt(Encrypter.Encrypt(pPassword)))
            {
                return true;
            }
            return false;
       }


        public bool VerifyMail(string pEmail)
        {
            return Regex.IsMatch(pEmail, @"^.+[@].+[.com]{ 4}$");
        }

    }
}
