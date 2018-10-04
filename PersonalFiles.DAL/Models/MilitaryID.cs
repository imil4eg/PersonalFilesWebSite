using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFiles.DAL
{
    public class MilitaryID
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public int NumberOfUnit { get; set; }

        public string Place { get; set; }

        [DataType(DataType.Date)]
        public DateTime BegginingDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public string Rank { get; set; }

        public string GaveBy { get; set; }
    }
}
