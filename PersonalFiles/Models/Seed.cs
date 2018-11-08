using Microsoft.AspNetCore.Identity;
using PersonalFiles.BLL;
using PersonalFiles.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFiles
{
    /// <summary>
    /// Initilization class
    /// </summary>
    public class Seed
    {
        public static async System.Threading.Tasks.Task InitializeDataAsync(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager,
            IPersonService personService, IPositionService positionService, IPersonPositionService personPositionService, IEducationService educationService,
            IInsuranceService insuranceService, IPassportService passportService)
        {
            #region Roles

            var existRole = await roleManager.FindByNameAsync("Admin");
            if (existRole == null)
            {
                string[] roleNames = { "Admin", "WriteAndRead", "Read" };

                foreach (string roleName in roleNames)
                {
                    await roleManager.CreateAsync(new ApplicationRole(roleName));
                }
            }

            #endregion

            #region User

            var existUser = await userManager.FindByNameAsync("Admin");
            if (existUser == null)
            {
                var admin = new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "admin@mail.ru",
                    IsDeleted = false
                };
                var createdAdmin = await userManager.CreateAsync(admin, "Admin1;");
                if (createdAdmin.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }

                var writeAndreadUser = new ApplicationUser
                {
                    UserName = "Writer",
                    Email = "writer@mail.ru",
                    IsDeleted = false
                };
                var createdWriter = await userManager.CreateAsync(writeAndreadUser, "Writer1;");
                if (createdWriter.Succeeded)
                {
                    await userManager.AddToRoleAsync(writeAndreadUser, "WriteAndRead");
                }

                var readUser = new ApplicationUser
                {
                    UserName = "Reader",
                    Email = "reader@mail.ru",
                    IsDeleted = false
                };
                var createdReader =  await userManager.CreateAsync(readUser, "Reader1;");
                if (createdReader.Succeeded)
                {
                    await userManager.AddToRoleAsync(readUser, "Read");
                }
            }

            #endregion

            if (!personService.GetPersons().Any())
            {
                #region Person

                IList<Person> persons = new List<Person>()
                {
                    new Person
                    {
                        LastName = "Михаилович",
                        FirstName = "Михаил",
                        MiddleName = "Михайлович",
                        Gender = DAL.Gender.Мужской,
                        INN = "85464586458",
                        SNILS = "9392149239"
                    },
                    new Person
                    {
                        LastName = "Васильева",
                        FirstName = "Василиса",
                        MiddleName = "Васюткина",
                        Gender = DAL.Gender.Женский,
                        INN = "228",
                        SNILS = "322"
                    },
                    new Person
                    {
                        LastName = "Петров",
                        FirstName = "Петя",
                        MiddleName = "Петрович",
                        Gender = DAL.Gender.Мужской,
                        INN = "549593",
                        SNILS = "483943"
                    },
                    new Person
                    {
                        LastName = "Алексеев",
                        FirstName = "Алеша",
                        MiddleName = "Михайлович",
                        Gender = DAL.Gender.Мужской,
                        INN = "9549",
                        SNILS = "954394"
                    },
                    new Person
                    {
                        LastName = "Кекмен",
                        FirstName = "Татьяна",
                        MiddleName = "Васюткина",
                        Gender = DAL.Gender.Женский,
                        INN = "22823",
                        SNILS = "3222342"
                    },
                    new Person
                    {
                        LastName = "Жульбарс",
                        FirstName = "Петя",
                        MiddleName = "Петрович",
                        Gender = DAL.Gender.Мужской,
                        INN = "45636",
                        SNILS = "34534"
                    }
                };

                foreach (var person in persons)
                {
                    personService.CreatePerson(person);
                }

                #endregion
                #region Position

                var positions = new Position[] { new Position { Name = "Директор" }, new Position { Name = "Инженер" }, new Position { Name = "Бухгалтер" } };
                foreach (var position in positions)
                {
                    positionService.CreatePosition(position);
                }

                #endregion
                #region PersonPosition

                persons = personService.GetPersons().ToList();
                positions = positionService.GetAllPosition().ToArray();
                Random rnd = new Random();
                foreach (var person in persons)
                {
                    personPositionService.AddPersonPosition(new PersonPosition
                    {
                        PersonId = person.Id,
                        PositionId = positions[rnd.Next(0, 3)].Id
                    });
                }

                #endregion
                #region Passport

                var passports = new Passport[]
                {
                    new Passport
                    {
                        PersonId = persons[0].Id,
                        Series = rnd.Next(100000, 999999).ToString(),
                        Number = rnd.Next(1000, 9999).ToString(),
                        Address = "Алтайский район",
                        DateOfGive = DateTime.Today,
                        GivenBy = "Отделом УФМС"
                    },
                    new Passport
                    {
                        PersonId = persons[1].Id,
                        Series = rnd.Next(100000, 999999).ToString(),
                        Number = rnd.Next(1000, 9999).ToString(),
                        Address = "Алтайский район",
                        DateOfGive = DateTime.Today,
                        GivenBy = "Отделом УФМС"
                    },
                    new Passport
                    {
                        PersonId = persons[2].Id,
                        Series = rnd.Next(100000, 999999).ToString(),
                        Number = rnd.Next(1000, 9999).ToString(),
                        Address = "Алтайский район",
                        DateOfGive = DateTime.Today,
                        GivenBy = "Отделом УФМС"
                    },
                    new Passport
                    {
                        PersonId = persons[3].Id,
                        Series = rnd.Next(100000, 999999).ToString(),
                        Number = rnd.Next(1000, 9999).ToString(),
                        Address = "Алтайский район",
                        DateOfGive = DateTime.Today,
                        GivenBy = "Отделом УФМС"
                    },
                    new Passport
                    {
                        PersonId = persons[4].Id,
                        Series = rnd.Next(100000, 999999).ToString(),
                        Number = rnd.Next(1000, 9999).ToString(),
                        Address = "Алтайский район",
                        DateOfGive = DateTime.Today,
                        GivenBy = "Отделом УФМС"
                    },
                    new Passport
                    {
                        PersonId = persons[5].Id,
                        Series = rnd.Next(100000, 999999).ToString(),
                        Number = rnd.Next(1000, 9999).ToString(),
                        Address = "Алтайский район",
                        DateOfGive = DateTime.Today,
                        GivenBy = "Отделом УФМС"
                    }
                };
                foreach (var passport in passports)
                {
                    passportService.CreatePassport(passport);
                }

                #endregion
                #region Insurance

                var insurances = new InsurancePolicy[]
                {
                    new InsurancePolicy
                    {
                        PersonId = persons[0].Id,
                        Number = rnd.Next(10000000, 99999999).ToString(),
                        Company = "Ак Барс"
                    },
                    new InsurancePolicy
                    {
                        PersonId = persons[1].Id,
                        Number = rnd.Next(10000000, 99999999).ToString(),
                        Company = "Мед. страх"
                    },
                    new InsurancePolicy
                    {
                        PersonId = persons[2].Id,
                        Number = rnd.Next(10000000, 99999999).ToString(),
                        Company = "Мед. страх"
                    },
                    new InsurancePolicy
                    {
                        PersonId = persons[3].Id,
                        Number = rnd.Next(10000000, 99999999).ToString(),
                        Company = "Ак Барс"
                    },
                    new InsurancePolicy
                    {
                        PersonId = persons[4].Id,
                        Number = rnd.Next(10000000, 99999999).ToString(),
                        Company = "Ак Барс"
                    },
                    new InsurancePolicy
                    {
                        PersonId = persons[5].Id,
                        Number = rnd.Next(10000000, 99999999).ToString(),
                        Company = "Ак Барс"
                    }
                };
                foreach(var insurance in insurances)
                {
                    insuranceService.CreatePolicy(insurance);
                }

                #endregion
            }
        }
    }
}
