using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalFiles.Models
{
    public class EditProfileViewModel
    {
        public int Id { get; set; }

        [DisplayName("Фамилия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string MiddleName { get; set; }

        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        public byte[] Image { get; set; }

        [DisplayName("СНИЛС")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string SNILS { get; set; }

        [DisplayName("ИНН")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Это поле не может быть пустым")]
        public string INN { get; set; }

        #region Passport

        [DisplayName("Номер")]
        public string PassportNumber { get; set; }

        [DisplayName("Серия")]
        public string PassportSeries { get; set; }

        [DisplayName("Кем выдан")]
        public string PassportGivenBy { get; set; }

        [DisplayName("Дата выдачи")]
        public DateTime PassportDateOfGive { get; set; }

        [DisplayName("Адрес выдачи")]
        public string PassportAddress { get; set; }

        #endregion

        #region Insurance

        [DisplayName("Номер страховки")]
        public string InsuranceNumber { get; set; }

        [DisplayName("Компания")]
        public string InsuranceCompany { get; set; }

        #endregion

        public PostViewModel PersonsPost { get; set; }

        public IList<EducationViewModel> Educations { get; set; }

        public SelectPostViewModel SelectPost { get; set; }
    }
}
