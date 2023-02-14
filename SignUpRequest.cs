using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Linki.SharedResources
{
    public class SignUpRequest : Request
    {
        [Required(ErrorMessage = "Поле логина не должно быть пустым")]
        public string Login { get; set; }


        [Required(ErrorMessage = "Поле никнейма не должно быть пустым")]
        public string Nickname { get; set; }


        [Required(ErrorMessage = "Поле e-mail адреса не должно быть пустым")]
        [EmailAddress(ErrorMessage = "Неправильный формат e-mail адреса")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле пароля не должно быть пустым")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Поле повтора пароля не должно быть пустым")]
        [Compare("Password", ErrorMessage = "Повторённый пароль должен совпадать с оригинальным")]
        public string ConfirmPassword { get; set; }
    }
}
