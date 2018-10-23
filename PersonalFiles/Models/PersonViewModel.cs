namespace PersonalFiles.Models
{
    public sealed class PersonViewModel
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public Gender Gender { get; set; }

        public string SNILS { get; set; }

        public string INN { get; set; }
    }
}
