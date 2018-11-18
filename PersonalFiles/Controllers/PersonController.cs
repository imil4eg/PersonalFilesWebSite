using Microsoft.AspNetCore.Mvc;
using PersonalFiles.BLL;
using AutoMapper;
using PersonalFiles.Models;
using System.Collections.Generic;
using PersonalFiles.DAL;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace PersonalFiles.Controllers
{
    [Authorize]
    public sealed class PersonController : Controller
    {
        #region Private Fields

        /// <summary>
        /// Actions for Person class
        /// </summary>
        private readonly IPersonService _personService;

        /// <summary>
        /// Actions for Education class
        /// </summary>
        private readonly IEducationService _educationService;

        /// <summary>
        /// Actions for Insruance class
        /// </summary>
        private readonly IInsuranceService _insuranceService;

        /// <summary>
        /// Actions for Passport class
        /// </summary>
        private readonly IPassportService _passportService;

        /// <summary>
        /// Actions for Position class
        /// </summary>
        private readonly IPositionService _positionService;

        /// <summary>
        /// Access to db for table for PersonPosition
        /// </summary>
        private readonly IPersonPositionService _personPositionService;

        /// <summary>
        /// Mapper for objects
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public PersonController(IPersonService personService, IEducationService educationService, IPassportService passportService,
            IInsuranceService insuranceService, IPositionService positionService, IPersonPositionService personPositionService, IMapper mapper)
        {
            this._personService = personService;
            this._educationService = educationService;
            this._insuranceService = insuranceService;
            this._passportService = passportService;
            this._positionService = positionService;
            this._personPositionService = personPositionService;
            this._mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult Persons()
        {
            var persons = this._personService.GetPersonsWithPosts();
            IEnumerable<PersonViewModel> models = this._mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(persons);

            return View(models);
        }

        [HttpGet]
        public IActionResult Profile(int personId)
        {
            PersonViewModel person = this._mapper.Map<Person, PersonViewModel>(this._personService.GetPersonWithPosts(personId));
            person.Educations = this._mapper.Map<IEnumerable<Education>, IList<EducationViewModel>>(this._educationService.GetAllPersonsEducation(personId));
            person.Insurance = this._mapper.Map<InsurancePolicy, InsuranceViewModel>(this._insuranceService.GetPolicyById(personId));
            person.Passport = this._mapper.Map<Passport, PassportViewModel>(this._passportService.GetPassportById(personId));
            return View(person);
        }

        [HttpGet]
        public IActionResult EditProfile(int personId)
        {
            PersonViewModel person = this._mapper.Map<Person, PersonViewModel>(this._personService.GetPersonWithPosts(personId));
            person.Educations = this._mapper.Map<IEnumerable<Education>, IList<EducationViewModel>>(this._educationService.GetAllPersonsEducation(personId));
            person.Insurance = this._mapper.Map<InsurancePolicy, InsuranceViewModel>(this._insuranceService.GetPolicyById(personId));
            person.Passport = this._mapper.Map<Passport, PassportViewModel>(this._passportService.GetPassportById(personId));
            EditProfileViewModel model = ConvertPersonToEditProfile(person);
            model.SelectPost = new SelectPostViewModel
            {
                PostId = person.Post.Id,
                Posts = this._positionService.GetAllPosition()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> EditProfile(EditProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var files = HttpContext.Request.Form.Files;

            var passport = new Passport
            {
                PersonId = model.Id,
                Series = model.PassportSeries,
                Number = model.PassportNumber,
                GivenBy = model.PassportGivenBy,
                Address = model.PassportAddress,
                DateOfGive = model.PassportDateOfGive
            };
            this._passportService.UpdatePassport(passport);

            var insurance = new InsurancePolicy
            {
                PersonId = model.Id,
                Number = model.InsuranceNumber,
                Company = model.InsuranceCompany
            };
            this._insuranceService.UpdatePolicy(insurance);

            if (model.SelectPost.PostId != model.PersonsPost.Id)
            {
                var personPosition = this._personPositionService.GetPersonPositionById(model.Id);
                personPosition.PositionId = model.SelectPost.PostId;
                this._personPositionService.UpdatePersonPosition(personPosition);
            }

            var person = new Person
            {
                Id = model.Id,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Gender = (DAL.Gender)model.Gender,
                INN = model.INN,
                MiddleName = model.MiddleName,
                SNILS = model.SNILS
            };

            if (files.Count > 0)
            {
                var allowedExtensions = new[] { ".png", ".jpg" };
                foreach (var file in files)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        string fileExtension = Path.GetExtension(file.FileName);
                        if (!allowedExtensions.Contains(fileExtension))
                        {
                            return View(model);
                        }
                        person.Image = memoryStream.ToArray();
                    }
                }
            }

            this._personService.UpdatePerson(person);

            return RedirectToAction("Persons", "Person");
        }

        [HttpGet]
        public IActionResult CreateProfile()
        {
            var model = new CreateProfileViewModel();
            model.Education = new EducationViewModel();
            model.SelectPost = new SelectPostViewModel();
            model.SelectPost.Posts = this._positionService.GetAllPosition();
            model.SelectPost.PostId = model.SelectPost.Posts.FirstOrDefault().Id;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> CreateProfile(CreateProfileViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                model.SelectPost.Posts = this._positionService.GetAllPosition();
                model.SelectPost.PostId = model.SelectPost.Posts.FirstOrDefault().Id;
                return View(model);
            }

            var person = new Person
            {
                LastName = model.LastName,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                Gender = (DAL.Gender)model.Gender,
                INN = model.INN,
                SNILS = model.SNILS,
                Post = new Position
                {
                    Id = model.SelectPost.PostId
                }
            };

            var education = new Education();

            var files = HttpContext.Request.Form.Files;
            if(files.Count > 0)
            {
                var allowedExtensions = new[] { ".png", ".jpg" };
                foreach (var file in files)
                {
                    if(file.Name == "profileImage")
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            string fileExtension = Path.GetExtension(file.FileName);
                            if (!allowedExtensions.Contains(fileExtension))
                            {
                                return View(model);
                            }
                            person.Image = memoryStream.ToArray();
                        }
                    }
                    else if(file.Name == "educationImage")
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            string fileExtension = Path.GetExtension(file.FileName);
                            if (!allowedExtensions.Contains(fileExtension))
                            {
                                return View(model);
                            }
                            education.File = memoryStream.ToArray();
                        }
                    }
                }
            }
            var resultPerson = this._personService.CreatePerson(person);

            var personPosition = new PersonPosition
            {
                PersonId = resultPerson.Id,
                PositionId = model.SelectPost.PostId
            };
            this._personPositionService.AddPersonPosition(personPosition);

            if (education.File != null)
            {
                education.EndDate = model.Education.EndDate;
                education.PersonId = resultPerson.Id;
                this._educationService.CreateEducation(education);
            }

            var passport = new Passport
            {
                PersonId = resultPerson.Id,
                Series = model.PassportSeries,
                Number = model.PassportNumber,
                GivenBy = model.PassportGivenBy,
                Address = model.PassportAddress,
                DateOfGive = model.PassportDateOfGive
            };
            this._passportService.CreatePassport(passport);

            var insurance = new InsurancePolicy
            {
                PersonId = resultPerson.Id,
                Number = model.InsuranceNumber,
                Company = model.InsuranceCompany
            };
            this._insuranceService.CreatePolicy(insurance);

            return RedirectToAction("Persons", "Person");
        }

        public IActionResult DeleteProfile(int personId)
        {
            var personEducations = this._educationService.GetAllPersonsEducation(personId);
            foreach(var education in personEducations)
            {
                this._educationService.DeleteEducation(education.Id);
            }

            this._insuranceService.DeletePolicy(personId);

            this._passportService.DeletePassport(personId);

            var personPosition = this._personPositionService.GetPersonPositionById(personId);
            this._personPositionService.RemovePersonPosition(personPosition.Id);

            this._personService.DeletePerson(personId);

            return RedirectToAction("Persons", "Person");
        }

        [NonAction]
        public EditProfileViewModel ConvertPersonToEditProfile(PersonViewModel person)
        {
            EditProfileViewModel model = new EditProfileViewModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Gender = person.Gender,
                Educations = person.Educations,
                Id = person.Id,
                Image = person.Image,
                INN = person.INN,
                InsuranceCompany = person.Insurance.Company,
                InsuranceNumber = person.Insurance.Number,
                MiddleName = person.MiddleName,
                PassportAddress = person.Passport.Address,
                PassportDateOfGive = person.Passport.DateOfGive,
                PassportGivenBy = person.Passport.GivenBy,
                PassportNumber = person.Passport.Number,
                PassportSeries = person.Passport.Series,
                PersonsPost = person.Post,
                SNILS = person.SNILS
            };

            return model;
        }

        [NonAction]
        public ActionResult RenderImage(int id)
        {
            var item = this._educationService.GetEducationById(id);
            return File(item.File.ToArray(), "image/png");
        }

        #endregion
    }
}