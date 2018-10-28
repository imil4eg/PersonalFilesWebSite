using System;
using System.ComponentModel;

namespace PersonalFiles.Models
{
    public sealed class PassportViewModel
    {
        public int PersonId { get; set; }

        [DisplayName("Номер")]
        public string Number { get; set; }

        [DisplayName("Серия")]
        public string Series { get; set; }

        [DisplayName("Кем выдан")]
        public string GivenBy { get; set; }

        [DisplayName("Дата выдачи")]
        public DateTime DateOfGive { get; set; }

        [DisplayName("Адрес выдачи")]
        public string Address { get; set; }
    }
}
