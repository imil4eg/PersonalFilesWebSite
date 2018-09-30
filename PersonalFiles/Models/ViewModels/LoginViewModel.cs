using System.ComponentModel;

namespace PersonalFiles.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// Users login
        /// </summary>
        [DisplayName("Имя пользователя")]
        public string Login { get; set; }

        /// <summary>
        /// Users password
        /// </summary>
        [DisplayName("Пароль")]
        public string Password { get; set; }

        /// <summary>
        /// Do we need to remember user
        /// </summary>
        [DisplayName("Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
