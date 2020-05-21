using MicroServiceExample.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace MicroServiceExample
{
    public class PersonStorage
    {
        public static PersonStorage Instance { get; } = new PersonStorage();

        public Collection<Person> Persons { get; } = new Collection<Person>();

        public PersonStorage()
        {
            Persons.Add(new Person() { Id = 1, Name = "John", Lastname = "O'Connor", DateOfBirth = new DateTime(1980, 12, 2) });
            Persons.Add(new Person() { Id = 2, Name = "Jane", Lastname = "Doe", DateOfBirth = new DateTime(1985, 3, 22) });
        }

        public void Add(Person person)
        {
            Persons.Add(person);
        }

        public Person Find(int id)
        {
            return Persons.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Update(int id, Person person)
        {
            var personInfo = Find(id);
            if (personInfo != null)
            {
                personInfo.Id = person.Id;
                personInfo.Name = person.Name;
                personInfo.Lastname = person.Lastname;
                personInfo.DateOfBirth = person.DateOfBirth;
            }
        }

        public void Delete(int id)
        {
            Persons.Remove(Find(id));
        }
    }
}
