﻿using System.ComponentModel.DataAnnotations;

namespace TrPo.Models
{
    public class LoginModel
    {
        //[Required(ErrorMessage = "Enter Email!")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Enter Password!")]
        public string Password { get; set; }
    }
}
