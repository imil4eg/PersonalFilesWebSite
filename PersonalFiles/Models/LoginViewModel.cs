using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// Users login
        /// </summary>
        [DisplayName("Имя пользователя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string UserName { get; set; }

        /// <summary>
        /// Users password
        /// </summary>
        [DisplayName("Пароль")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string Password { get; set; }

        /// <summary>
        /// Do we need to remember user
        /// </summary>
        [DisplayName("Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
