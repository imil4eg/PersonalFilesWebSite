using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.DAL
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50 ,MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 2)]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public Gender Gender { get; set; }

        [StringLength(11)]
        public string SNILS { get; set; }

        [StringLength(13)]
        public string INN { get; set; }

        public IEnumerable<byte> Image { get; set; }
    }

    public enum Gender
    {
        Мужской,
        Женский
    }
}
