using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFiles.DAL
{
    public class OtherDocument
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public string DocumentType { get; set; }

        public IEnumerable<byte> File { get; set; }

        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
    }
}
