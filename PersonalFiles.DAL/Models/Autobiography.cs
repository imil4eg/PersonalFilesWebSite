using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFiles.DAL
{
    public class Autobiography
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public IEnumerable<byte> File { get; set; }
    }
}
