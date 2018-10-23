using Microsoft.AspNetCore.Mvc;
using PersonalFiles.BLL;
using AutoMapper;
using PersonalFiles.Models;
using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.Controllers
{
    public sealed class PersonController : Controller
    {
        #region Private Fields

        /// <summary>
        /// Actions for Person class
        /// </summary>
        private readonly IPersonService _personService;

        /// <summary>
        /// Mapper for objects
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public PersonController(IPersonService personService, IMapper mapper)
        {
            this._personService = personService;
            this._mapper = mapper;
        }

        #endregion

        public IActionResult Persons()
        {
            var persons = this._personService.GetPersons();
            IEnumerable<PersonViewModel> models = this._mapper.Map<IEnumerable<Person>,IEnumerable<PersonViewModel>>(persons);

            return View(models);
        }
    }
}