using System.ComponentModel;

namespace PersonalFiles.Models
{
    public sealed class InsuranceViewModel
    {
        public int PersonId { get; set; }

        [DisplayName("Номер страховки")]
        public string Number { get; set; }

        [DisplayName("Компания")]
        public string Company { get; set; }
    }
}
