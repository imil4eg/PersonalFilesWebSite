using System.Collections.Generic;

namespace PersonalFiles.Models
{
    public sealed class PersonViewModel
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public Gender Gender { get; set; }

        public string SNILS { get; set; }

        public string INN { get; set; }

        public IEnumerable<string> Posts { get; set; }

        public PassportViewModel Passport { get; set; }

        public IList<EducationViewModel> Educations { get; set; }

        public InsuranceViewModel Insurance { get; set; }
    }
}
