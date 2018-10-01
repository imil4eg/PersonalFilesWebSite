using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFiles.DAL
{
    public class WorkBook
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Post { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public DateTime DateOfBeggining { get; set; }
    }
}
