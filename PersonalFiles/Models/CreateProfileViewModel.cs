using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.Models
{
    public sealed class CreateProfileViewModel
    {
        [DisplayName("Фамилия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        public string MiddleName { get; set; }

        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        public IFormFile Image { get; set; }

        [DisplayName("СНИЛС")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string SNILS { get; set; }

        [DisplayName("ИНН")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string INN { get; set; }

        #region Passport

        [DisplayName("Номер")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string PassportNumber { get; set; }

        [DisplayName("Серия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string PassportSeries { get; set; }

        [DisplayName("Кем выдан")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string PassportGivenBy { get; set; }

        [DisplayName("Дата выдачи")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public DateTime PassportDateOfGive { get; set; }

        [DisplayName("Адрес выдачи")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string PassportAddress { get; set; }

        #endregion

        #region Insurance

        [DisplayName("Номер страховки")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string InsuranceNumber { get; set; }

        [DisplayName("Компания")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string InsuranceCompany { get; set; }

        #endregion

        public PostViewModel PersonsPost { get; set; }

        public EducationViewModel Education { get; set; }

        public SelectPostViewModel SelectPost { get; set; }

        public bool CreateEducation { get; set; }
    }
}
