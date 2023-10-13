using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WinFormTask_2.Forms.Form1.Classes;

namespace WinFormTask_2.Forms.Form1.DataBase
{
    public class DataBase
    {
        List<Person>? People { get; set; }


        public DataBase()
        {
            if (File.Exists(@"../../../../people.json"))
                People = GetAllPeopleFromDataBase();

            else
            {
                People = new List<Person>();
                File.WriteAllText(@"../../../../people.json", JsonSerializer.Serialize(People));
            }
        }

        public void AddPersonToDataBase(Person person)
        {
            for (int i = 0; i < People!.Count; i++)
            {
                if(person.ID == People[i].ID)
                {
                    People[i] = person;
                    WriteAllPeopleToDataBase();
                    return;
                }
            }

            People!.Add(person);

            WriteAllPeopleToDataBase();
        }

        public void WriteAllPeopleToDataBase()
        {
            File.WriteAllText(@"../../../../people.json", JsonSerializer.Serialize(People));
        }


        public Person FindPersonByID(string? id)
        {
            List<Person> people = GetAllPeopleFromDataBase();

            if (people.Count > 0)
            {
                foreach (Person person in people)
                {
                    if (id == person.ID) return person;
                }
                return null!;
            }

            return null!;
        }


        public Person FindPersonByMail(string? mail)
        {
            List<Person> people = GetAllPeopleFromDataBase();

            if (people.Count > 0)
            {
                foreach (Person person in people)
                {
                    if (mail == person.Mail) return person;
                }

                return null!;
            }
            return null!;
        }


        public List<Person> GetAllPeopleFromDataBase()
        {
            List<Person>? people = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(@"../../../../people.json"));
            return people!;
        }
    }
}
