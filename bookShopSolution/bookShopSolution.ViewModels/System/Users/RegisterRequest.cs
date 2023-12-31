﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShopSolution.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}