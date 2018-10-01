using System;

namespace PersonalFiles.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Person> Persons { get; }
        IRepository<Education> Educations { get; }
        IRepository<Autobiography> Authobiographys { get; }
        IRepository<InsurancePolicy> Insurances { get; }
        IRepository<MilitaryID> MilitaryIDs { get; }
        IRepository<OtherDocument> OthreDocuments { get; }
        IRepository<Passport> Passports { get; }
        IRepository<ScientificWork> ScientificWorks { get; }
        IRepository<WorkBook> WorkBooks { get; }
        IRepository<WorkContract> WorkContacts { get; }
        void Save();
    }
}
