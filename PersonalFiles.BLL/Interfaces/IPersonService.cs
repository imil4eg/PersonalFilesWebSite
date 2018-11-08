using System.Collections.Generic;
using PersonalFiles.DAL;

namespace PersonalFiles.BLL
{
    public interface IPersonService
    {
        Person CreatePerson(Person person);
        void DeletePerson(int id);
        Person GetPersonById(int id);
        IEnumerable<Person> GetPersons();
        void UpdatePerson(Person person);
        IEnumerable<Person> GetPersonsWithPosts();
        Person GetPersonWithPosts(int id);
    }
}