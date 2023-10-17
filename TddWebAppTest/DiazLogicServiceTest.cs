using System.ComponentModel;
using System;
using System.Net;
using TddApp;
using TddWebApp;

namespace TddWebAppTest
{
    public class DiazLogicServiceTest
    {
        [Fact]
        public void CorrectInput_Returns_CorrectValue()
        {
            // Arrange
            IDiazService logicService = new DiazService();
            // Act
            var res = logicService.MySuperLogic(11, 22, 33, 44);

            // Assert
            Assert.Equal(34, res.Result);

        }

        [Fact]
        public void WrongInput_Throws_Exception()
        {
            // Arrange
            IDiazService logicService = new DiazService();
            int wrongNumber = -2;
            // Act
            var ex = Assert.Throws<Exception>(() => logicService.MySuperLogic(wrongNumber, 666, 13, 1423));

            // Assert
            Assert.Equal($"The number {wrongNumber} is not in the range of 1 to 10000", ex.Message);
        }

        [Fact]
        public void Input_Contains_DiscardValues_Exception()
        {
            // Arrange
            IDiazService logicService = new DiazService();
            // Act
            var ex = Assert.Throws<Exception>(() => logicService.MySuperLogic(10, 22, 33, 44));

            // Assert
            Assert.Equal("The array contains invalid numbers", ex.Message);
        }
    }
}
