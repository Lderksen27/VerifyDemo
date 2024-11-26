using PersonDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemoTest

{
    public class PersonTestVerify
    {
        [Fact]
        public Task PersonTest() 
        {
            //Arrange
            string fullName = "Piet Jansen";
            int age = 35;
            string licensePlate = "BB-111-A";

            //Act
            Taxidriver createdPerson = new Taxidriver(fullName, age, licensePlate);

            //Assert
            return Verify(createdPerson);
        }
    }
}
