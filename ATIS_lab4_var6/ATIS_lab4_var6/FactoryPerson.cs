using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6
{
    internal class FactoryPerson
    {
        public static List<Person> persons = new List<Person>();
        public enum IDPerson { Manager_Id, Doktor_Id, Cleaner_Id, Worker_Id };

        public static void listPerson()
        {
            string position = "менеджер";
            string name = "";
            Person person = new Doctor(Guid.NewGuid(), position, name);
            persons.Add(person);
        }

        public static Person createPerson(IDPerson id, string position, string name)
        {
            switch (id)
            {
                case IDPerson.Manager_Id:
                    {
                        Person person = new Manager(Guid.NewGuid(), position, name);
                        persons.Add(person);
                        return person;
                    }
                case IDPerson.Doktor_Id:
                    {
                        Person person = new Doctor(Guid.NewGuid(), position, name);
                        persons.Add(person);
                        return person; ;
                    }
                case IDPerson.Cleaner_Id:
                    {
                        Person person = new Cleaner(Guid.NewGuid(), position, name);
                        persons.Add(person);
                        return person;
                    }
                case IDPerson.Worker_Id:
                    {
                        Person person = new Worker(Guid.NewGuid(), position, name);
                        persons.Add(person);
                        return person;
                    }
                default:
                    return null;

            }
        }
    }
}
