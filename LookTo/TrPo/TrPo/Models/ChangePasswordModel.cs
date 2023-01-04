using System.ComponentModel.DataAnnotations;

namespace TrPo.Models
{
    public class ChangePasswordModel
    {

        public string OldPassword { get; set; }

        //[Required(ErrorMessage = "Enter new password!")]
        //[Compare("OldPassword", ErrorMessage = "Новый пароль не может быть похож на старый")]
        public string NewPassword { get; set; }

        //[Required(ErrorMessage = "Repeat password!")]
        [Compare("NewPassword", ErrorMessage = "Введите повторно пароль верно")]
        public string RepeatPassword { get; set; }
    }
}
