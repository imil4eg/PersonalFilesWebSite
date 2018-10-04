using Microsoft.Extensions.Configuration;

namespace PersonalFiles.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly string connectionString;

        public UnitOfWork(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection"); 
        }

        public UnitOfWork()
        {
            Persons = new PersonRepository(connectionString);
            Educations = new EducationRepository(connectionString);
            Authobiographys = new AutobiographyRepository(connectionString);
            Insurances = new InsuranceRepository(connectionString);
            MilitaryIDs = new MilitaryIdRepository(connectionString);
            OtherDocuments = new OtherDocmentRepository(connectionString);
            Passports = new PassportRepository(connectionString);
            ScientificWorks = new ScientificWorkRepository(connectionString);
            WorkBooks = new WorkBookRepository(connectionString);
            WorkContacts = new WorkContactRepository(connectionString);
        }

        public IPersonRepository Persons { get; private set; }
        public IEducationRepository Educations { get; private set; }
        public IAutobiographyRepository Authobiographys { get; private set; }
        public IInsurancePolicyRepository Insurances { get; private set; }
        public IMilitaryIdRepository MilitaryIDs { get; private set; }
        public IOtherDocumentRepository OtherDocuments { get; private set; }
        public IPassportRepository Passports { get; private set; }
        public IScientificWorkRepository ScientificWorks { get; private set; }
        public IWorkBookRepository WorkBooks { get; private set; }
        public IWorkContactRepository WorkContacts { get; private set; }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
