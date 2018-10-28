using Microsoft.AspNetCore.Mvc;
using PersonalFiles.BLL;
using AutoMapper;
using PersonalFiles.Models;
using System.Collections.Generic;
using PersonalFiles.DAL;

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
        /// Mapper for objects
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public PersonController(IPersonService personService, IEducationService educationService, IPassportService passportService,
            IInsuranceService insuranceService, IMapper mapper)
        {
            this._personService = personService;
            this._educationService = educationService;
            this._insuranceService = insuranceService;
            this._passportService = passportService;
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

        #endregion
    }
}