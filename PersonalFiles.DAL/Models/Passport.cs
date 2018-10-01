using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.DAL
{
    public class Passport
    {
        [Key]
        public int PersonId { get; set; }

        public string Number { get; set; }

        public string Series { get; set; }

        public string GivenBy { get; set; }

        public DateTime DateOfGive { get; set; }

        public string Address { get; set; }
    }
}
