using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле имя пользователя обязательное")]
        [DisplayName("Имя пользователя")]
        [MinLength(6, ErrorMessage = "Минимальная длина 6 символов")]
        public override string UserName { get => base.UserName; set => base.UserName = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле пароль обязательное")]
        [DisplayName("Пароль")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Минимальная длина 6 символов")]
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }
    }
}
