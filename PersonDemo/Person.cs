using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person(string fullName, int age) 
        {
            if (age < 18)
            {
                throw new ArgumentException("Driver too young!");
            }
            FullName = fullName;
            Age = age;
            Address = new Address
            {
                Street = "Hoofdstraat",
                HouseNumber = "15B",
                PostalCode = "1234AB",
                City = "Amsterdam",
                Country = "The Netherlands"
            };
        }

    }
}
