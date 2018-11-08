using PersonalFiles.DAL;

namespace PersonalFiles.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public ApplicationRole Role { get; set; }
    }
}
