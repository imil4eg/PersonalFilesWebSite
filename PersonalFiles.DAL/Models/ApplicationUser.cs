namespace PersonalFiles.DAL
{
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            this.IsDeleted = false;
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsDeleted { get; set; }
    }
}
