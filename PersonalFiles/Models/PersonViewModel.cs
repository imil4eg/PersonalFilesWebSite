using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.Models
{
    public sealed class PersonViewModel
    {
        public int Id { get; set; }

        [DisplayName("Фамилия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string MiddleName { get; set; }
        
        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        public byte[] Image { get; set; }

        [DisplayName("СНИЛС")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string SNILS { get; set; }

        [DisplayName("ИНН")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string INN { get; set; }

        [DisplayName("Должность")]
        public PostViewModel Post { get; set; }

        [DisplayName("Паспорт")]
        public PassportViewModel Passport { get; set; }

        [DisplayName("Образование")]
        public IList<EducationViewModel> Educations { get; set; }

        [DisplayName("Страховка")]
        public InsuranceViewModel Insurance { get; set; }
    }
}
