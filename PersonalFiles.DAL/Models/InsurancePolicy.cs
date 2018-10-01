using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFiles.DAL
{
    public class InsurancePolicy
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }
    }
}
