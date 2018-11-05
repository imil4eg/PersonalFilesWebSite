using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.Models
{
    public class SelectPostViewModel
    {
        public int PostId { get; set; }
        public IEnumerable<Position> Posts { get; set; }
    }
}
