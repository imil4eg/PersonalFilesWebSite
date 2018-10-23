namespace PersonalFiles.DAL
{
    public class ApplicationRole
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ApplicationRole(string roleName)
        {
            Name = roleName;
        }

        public ApplicationRole(int id, string roleName)
        {
            this.Id = id;
            this.Name = roleName;
        }

        public ApplicationRole()
        {

        }
    }
}
