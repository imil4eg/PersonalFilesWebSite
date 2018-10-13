﻿using System;

namespace PersonalFiles.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Persons { get; }
        IEducationRepository Educations { get; }
        IAutobiographyRepository Authobiographys { get; }
        IInsurancePolicyRepository Insurances { get; }
        IMilitaryIdRepository MilitaryIDs { get; }
        IPassportRepository Passports { get; }
        IWorkBookRepository WorkBooks { get; }
        IWorkContactRepository WorkContacts { get; }
    }
}
