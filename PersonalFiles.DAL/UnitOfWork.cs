namespace PersonalFiles.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly string connectionString;

        public UnitOfWork(string connectionString)
        {
            this.connectionString = connectionString;
            Persons = new PersonRepository(connectionString);
            Educations = new EducationRepository(connectionString);
            Insurances = new InsuranceRepository(connectionString);
            Passports = new PassportRepository(connectionString);
            PersonsPositions = new PersonPositionRepository(connectionString);
            Positions = new PositionRepository(connectionString);
            UserRole = new UserRoleRepository(connectionString);
        }

        public IPersonRepository Persons { get; private set; }
        public IEducationRepository Educations { get; private set; }
        public IInsurancePolicyRepository Insurances { get; private set; }
        public IPassportRepository Passports { get; private set; }
        public IPersonPositionRepository PersonsPositions { get; private set; }
        public IPositionRepository Positions { get; private set; }
        public IUserRoleRepository UserRole { get; private set; }

        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }
    }
}
