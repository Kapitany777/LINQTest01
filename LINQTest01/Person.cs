using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTest01
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public static List<Person> GetSampleData()
        {
            return new List<Person>
            {
                new Person("John", "Smith"),
                new Person("John", "White"),
                new Person("John", "Black"),
                new Person("John", "Brown"),
                new Person("Gordon", "Freeman"),
                new Person("Adrian", "Shephard"),
                new Person("Barney", "Calhoon"),
                new Person("Lawrence", "Barnes"),
                new Person("Michael", "Sykes")
            };
        }
    }
}
