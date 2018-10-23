using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IPersonPositionService
    {
        void AddPersonPosition(PersonPosition personPosition);
        PersonPosition GetPersonPositionById(int id);
        IEnumerable<PersonPosition> GetPersonsPositions();
        void RemovePersonPosition(int id);
        void UpdatePersonPosition(PersonPosition personPosition);
    }
}