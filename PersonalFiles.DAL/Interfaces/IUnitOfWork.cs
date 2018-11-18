using System;

namespace PersonalFiles.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Persons { get; }
        IEducationRepository Educations { get; }
        IInsurancePolicyRepository Insurances { get; }
        IPassportRepository Passports { get; }
        IPersonPositionRepository PersonsPositions { get; }
        IPositionRepository Positions { get; }
        IUserRoleRepository UserRole { get; }
    }
}
