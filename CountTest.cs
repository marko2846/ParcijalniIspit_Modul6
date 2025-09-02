using Microsoft.AspNetCore.Mvc;
using ParcijalniIspit6.Controllers;


namespace TestProject2
{
    public class CountTest
    {
        [Fact]
        public void CheckCountValue_Input500_ThrowsException()
        {
            // Arrange
            var controller = new HomeController();

            // Act & Assert
            Assert.Throws<Exception>(() => controller.CheckCountValue(500));

        }

        [Fact]
        public void CheckCountValue_Input2_DoesNotThrowException()
        {
            // Arrange
            var controller = new HomeController();

            // Act 
            var result = controller.CheckCountValue(2);

            // Assert
            Assert.InRange(2, 0, 20);


        }



        // Slučajevi za i < 20 
        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(19)]
        public void CheckCountValue_InputLessThan20(int input)
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.CheckCountValue(input);

            // Assert
            Assert.InRange(input, 0, 20);
            Assert.True(input < 20);
            
        }

        // Slučajevi za i >= 20 
        [Theory]
        [InlineData(20)]
        [InlineData(500)]
        public void CheckCountValue_InputGreaterOrEqual20(int input)
        {
            // Arrange
            var controller = new HomeController();

            // Act & Assert
            var iznimka = Assert.Throws<Exception>(() => controller.CheckCountValue(input));
            Assert.Equal("Broj je izvan raspona", iznimka.Message);
            Assert.True(input >= 20);
        }
    }


}

