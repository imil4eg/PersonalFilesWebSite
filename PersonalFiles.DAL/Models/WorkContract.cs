using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFiles.DAL
{
    public class WorkContract
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public IEnumerable<byte> File { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
