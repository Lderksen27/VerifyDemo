using PersonDemo;

namespace PersonDemoTest
{
    public class PersonTestRegular
    {
        [Fact]
        public void CreateTaxiDriver_Should_Return_Taxidriver()
        {
            //Arrange
            string fullName = "Piet Jansen";
            int age = 35;
            string licensePlate = "BB-111-A";

            //Act
            Taxidriver createdPerson = new Taxidriver(fullName, age, licensePlate);

            //Assert
            Assert.NotNull(createdPerson);
            Assert.True(createdPerson.isActive);
            Assert.Equal(fullName, createdPerson.FullName);
            Assert.Equal(licensePlate, createdPerson.LicensePlate);
            Assert.Equal(age, createdPerson.Age);
            Assert.Equal("Hoofdstraat", createdPerson.Address.Street);
            Assert.Equal("Amsterdam", createdPerson.Address.City);
        }

        [Fact]
        public void Underage_Taxidriver_Should_Throw_Exception()
        {
            // Arrange
            string fullName = "Henk de Vries";
            int age = 16;
            string licensePlate = "AA-999-X";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Taxidriver(fullName, age, licensePlate));
        }
    }
}
              
            
        
