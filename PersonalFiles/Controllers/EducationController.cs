using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalFiles.BLL;
using PersonalFiles.DAL;
using PersonalFiles.Models;
using System;
using System.IO;
using System.Linq;

namespace PersonalFiles.Controllers
{
    public class EducationController : Controller
    {

        #region Private Fields

        /// <summary>
        /// Access to DB for Education class
        /// </summary>
        private readonly IEducationService _educationService;

        /// <summary>
        /// Mapper
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="educationService"></param>
        public EducationController(IEducationService educationService, IMapper mapper)
        {
            this._educationService = educationService;
            this._mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult CreateEducation(int personId)
        {

            EducationViewModel model = new EducationViewModel();
            model.PersonId = personId;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> CreateEducation(EducationViewModel model)
        {
            if (model.EndDate.Equals(default(DateTime)))
            {
                return View(model);
            }

            var education = new Education
            {
                PersonId = model.PersonId,
                EndDate = model.EndDate
            };

            var allowedExtensions = new[] { ".png", ".jpg" };
            var files = HttpContext.Request.Form.Files;

            if(files.Count == 0)
            {
                return View(model);
            }

            using(var memoryStream = new MemoryStream())
            {
                await files[0].CopyToAsync(memoryStream);
                string fileExtension = Path.GetExtension(files[0].FileName);
                if(!allowedExtensions.Contains(fileExtension))
                {
                    return View(model);
                }
                education.File = memoryStream.ToArray();
            }

            this._educationService.CreateEducation(education);

            return RedirectToAction("EditProfile", "Person", new { personId = model.PersonId });
        }

        [HttpGet]
        public IActionResult EditEducation(int educationId)
        {
            EducationViewModel model = _mapper.Map<Education, EducationViewModel>(this._educationService.GetEducationById(educationId));

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> EditEducation(EducationViewModel model)
        {
            if(model.EndDate.Equals(default(DateTime)) || string.IsNullOrEmpty(model.EndDate.ToString()))
            {
                return View(model);
            }

            var education = new Education
            {
                Id = model.Id,
                PersonId = model.PersonId,
                EndDate = model.EndDate,
                File = model.File
            };

            var files = HttpContext.Request.Form.Files;

            if (files.Count > 0)
            {
                var allowedExtensions = new[] { ".png", ".jpg" };
                using (var memoryStream = new MemoryStream())
                {
                    await files[0].CopyToAsync(memoryStream);
                    string fileExtension = Path.GetExtension(files[0].FileName);
                    if (!allowedExtensions.Contains(fileExtension))
                    {
                        return View(model);
                    }
                    education.File = memoryStream.ToArray();
                }
            }

            this._educationService.UpdateEducation(education);

            return RedirectToAction("EditProfile", "Person", new { personId = model.PersonId });
        }

        [HttpGet]
        public IActionResult DeleteEducation(int personId, int educationId)
        {
            this._educationService.DeleteEducation(educationId);

            return RedirectToAction("EditProfile", "Person", new { personId = personId });
        }
        
        #endregion
    }
}