using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TrPo.Models
{
    public class ChangeInfoModel
    {
        public IFormFile Avatar { get; set; }

        //[Required(ErrorMessage = "Enter first name!")]
        public string FirstName { get; set; }
        
        //[Required(ErrorMessage = "Enter last name!")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Enter country!")]
        //public string Country { get; set; }

        //[Required(ErrorMessage = "Enter city!")]
        //public string City { get; set; }

        //[Required(ErrorMessage = "Enter sex!")]
        //public string Sex { get; set; }

        //[Required(ErrorMessage = "Enter birthday!")]
        //public string Birthday { get; set; }
    }
}
