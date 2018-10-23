using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IPersonService
    {
        void CreatePerson(Person person);
        void DeletePerson(int id);
        Person GetPersonById(int id);
        IEnumerable<Person> GetPersons();
        void UpdatePerson(Person person);
    }
}