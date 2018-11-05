using System.ComponentModel;

namespace PersonalFiles.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }
    }
}
