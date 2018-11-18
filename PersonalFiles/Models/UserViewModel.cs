using PersonalFiles.DAL;

namespace PersonalFiles.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsDeleted { get; set; }

        public string RoleName { get; set; }
    }
}
