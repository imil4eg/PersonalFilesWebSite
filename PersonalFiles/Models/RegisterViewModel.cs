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
        public string UserName { get; set; }

        [DisplayName("Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Подтверждение пароля")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
        
        [DisplayName("Эл. почта")]
        public string Email { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        public string MiddleName { get; set; }

        [DisplayName("День рождения")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; }
    }
}
