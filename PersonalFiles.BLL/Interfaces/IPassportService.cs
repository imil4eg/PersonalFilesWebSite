using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IPassportService
    {
        void CreatePassport(Passport passport);
        void DeletePassport(int id);
        IEnumerable<Passport> GetAll();
        Passport GetPassportById(int id);
        void UpdatePassport(Passport passport);
    }
}