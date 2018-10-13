namespace PersonalFiles.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly string connectionString;

        public UnitOfWork(string connectionString)
        {
            this.connectionString = connectionString; 
        }

        public UnitOfWork()
        {
            Persons = new PersonRepository(connectionString);
            Educations = new EducationRepository(connectionString);
            Authobiographys = new AutobiographyRepository(connectionString);
            Insurances = new InsuranceRepository(connectionString);
            MilitaryIDs = new MilitaryIdRepository(connectionString);
            Passports = new PassportRepository(connectionString);
            WorkBooks = new WorkBookRepository(connectionString);
            WorkContacts = new WorkContactRepository(connectionString);
        }

        public IPersonRepository Persons { get; private set; }
        public IEducationRepository Educations { get; private set; }
        public IAutobiographyRepository Authobiographys { get; private set; }
        public IInsurancePolicyRepository Insurances { get; private set; }
        public IMilitaryIdRepository MilitaryIDs { get; private set; }
        public IPassportRepository Passports { get; private set; }
        public IWorkBookRepository WorkBooks { get; private set; }
        public IWorkContactRepository WorkContacts { get; private set; }

        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }
    }
}
