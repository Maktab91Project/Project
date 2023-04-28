﻿using AppCore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Entity.RoleEntity
{
    public class Customer
    {
        public string Address { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        public RoleEnum Role { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
    }
}