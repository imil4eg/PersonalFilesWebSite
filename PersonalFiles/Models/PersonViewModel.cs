using System.Collections.Generic;
using System.ComponentModel;

namespace PersonalFiles.Models
{
    public sealed class PersonViewModel
    {
        public int Id { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        public string MiddleName { get; set; }
        
        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        [DisplayName("СНИЛС")]
        public string SNILS { get; set; }

        [DisplayName("ИНН")]
        public string INN { get; set; }

        [DisplayName("Должность")]
        public IEnumerable<string> Posts { get; set; }

        [DisplayName("Паспорт")]
        public PassportViewModel Passport { get; set; }

        [DisplayName("Образование")]
        public IList<EducationViewModel> Educations { get; set; }

        [DisplayName("Страховка")]
        public InsuranceViewModel Insurance { get; set; }
    }
}
