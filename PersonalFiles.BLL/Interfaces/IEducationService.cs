using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IEducationService
    {
        void CreateEducation(Education education);
        void DeleteEducation(int id);
        IEnumerable<Education> GetAll();
        IEnumerable<Education> GetAllPersonsEducation(int personId);
        Education GetEducationById(int id);
        void UpdateEducation(Education education);
    }
}