using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PersonalFiles.Models
{
    public sealed class EducationViewModel
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        [DisplayName("Файл")]
        public IEnumerable<byte> File { get; set; }

        [DisplayName("Дата окончания")]
        public DateTime EndDate { get; set; }
    }
}
