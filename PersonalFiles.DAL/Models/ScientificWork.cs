using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFiles.DAL
{
    public class ScientificWork
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public string WorkType { get; set; }

        public string WorkName { get; set; }

        public IEnumerable<byte> File { get; set; }
        
        public string Site { get; set; }

        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
    }
}
