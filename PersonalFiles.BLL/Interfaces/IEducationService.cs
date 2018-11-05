using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IEducationService
    {
        void CreateEducation(Education education);
        void DeleteEducation(int id);
        IEnumerable<Education> GetAll();
        IList<Education> GetAllPersonsEducation(int personId);
        Education GetEducationById(int id);
        void UpdateEducation(Education education);
    }
}