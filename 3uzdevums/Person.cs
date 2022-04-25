using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3uzdevums_4
{
    internal class Person
    {
        public Person()
        { }

        public Person(string name, string surname, DateTime birthdate, string hobby, bool gender)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            Hobby = hobby;
            Gender = gender;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public string Hobby { get; set; }
        public bool Gender { get; set; }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hello my name is {Name} {Surname} and i am {GetAge} old");
        }
    }
}
    
