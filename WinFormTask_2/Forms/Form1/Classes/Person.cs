using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTask_2.Forms.Form1.Classes
{
    public class Person
    {

        public string? ID { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? FatherName { get; set; }


        public string? Country { get; set; }

        public string? City { get; set; }

        public string? Phone { get; set; }

        public string? Mail { get; set; }
        public DateTime BirthDay { get; set; }

        public char Gender { get; set; }
        public Person(string? name, string? surname, string? fatherName, string? country, string? city, string? phone, string? mail, DateTime birthDay)
        {
            ID = Guid.NewGuid().ToString().Substring(0, 10);
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            Mail = mail;
            BirthDay = birthDay;
        }
        public Person()
        {
            
        }

    }
}
