using Microsoft.AspNetCore.Mvc;
using PersonalFiles.BLL;
using AutoMapper;
using PersonalFiles.Models;
using System.Collections.Generic;
using PersonalFiles.DAL;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.IO;

namespace PersonalFiles.Controllers
{
    //[Authorize(Roles = "Admin")]
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
        /// Mapper for objects
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public PersonController(IPersonService personService, IEducationService educationService, IPassportService passportService,
            IInsuranceService insuranceService, IPositionService positionService, IMapper mapper)
        {
            this._personService = personService;
            this._educationService = educationService;
            this._insuranceService = insuranceService;
            this._passportService = passportService;
            this._positionService = positionService;
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
            model.SelectPost = new List<SelectPostViewModel>();
            for(int i = 0;i < person.Posts.Count; i++)
            {
                model.SelectPost.Add(new SelectPostViewModel
                {
                    PostId = person.Posts[i].Id,
                    Posts = this._positionService.GetAllPosition()
                });
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult EditProfile(PersonViewModel model)
        {
            //var file = HttpContext.Request.Form.Files[0];
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View();
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
                PersonsPosts = person.Posts,
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