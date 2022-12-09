﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.IO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public bool Admin { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public int Score { get; set; }
        public byte[] Avatar { get; set; } 




    }
}
