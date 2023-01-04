//using System;
using System.ComponentModel.DataAnnotations;

namespace TrPo.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Введите повторно пароль верно!")]
        public string ConfirmPassword { get; set; }

        public string Nickname { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public string Country { get; set; }

        //public string City { get; set; }

        //public string Sex { get; set; }

        //[DataType(DataType.DateTime)]
        //public DateTime Birthday { get; set; }

    }
}
