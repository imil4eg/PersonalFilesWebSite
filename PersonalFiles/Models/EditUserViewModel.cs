namespace PersonalFiles.Models
{
    public sealed class EditUserViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public SelectRoleViewModel SelectRole { get; set; }
    }
}
