using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PersonalFiles.Models
{
    public sealed class EducationViewModel
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public int ItemIndex { get; set; }

        [DisplayName("Файл")]
        [FileExtensions(Extensions = "jpg|png", ErrorMessage = "Файл должен быть типа jpg или png")]
        public byte[] File { get; set; }
 
        [DisplayName("Дата окончания")]
        public DateTime EndDate { get; set; }
    }
}
