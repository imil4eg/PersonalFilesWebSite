using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.Models
{
    public class RegisterViewModel
    {
        /// <summary>
        /// Users login
        /// </summary>
        [DisplayName("Имя пользователя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string UserName { get; set; }

        [DisplayName("Пароль")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Пароль должен быть больше 8 символов")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string Password { get; set; }

        [DisplayName("Подтверждение пароля")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get; set; }
        
        [DisplayName("Эл. почта")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string Email { get; set; }

        [DisplayName("Фамилия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        public string MiddleName { get; set; }

        [DisplayName("День рождения")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Роль")]
        public SelectRoleViewModel UserRole { get; set; }

        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; }
    }
}
