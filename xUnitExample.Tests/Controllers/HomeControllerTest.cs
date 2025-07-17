using xUnitExample.Controllers;

namespace xUnitExample.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Get_ReturnsHelloWorld()
        {
            // Arrange
            var controller = new HomeController();
            string expectedResult = "Hello, World!";

            // Act
            var result = controller.GetWithFact();


            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(100, "You guessed correct number")]
        [InlineData(50, "You guessed too low")]
        [InlineData(150, "You guessed too high")]
        public void GetWithTheory_ReturnsExpectedResult(int guessNumber, string expectedMessage)
        {
            // Arrange
            var controller = new HomeController();
            // Act
            var result = controller.GetWithTheory(guessNumber);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedMessage, result);
        }
    }
}
