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
            Assert.Equal($"El número {wrongNumber} no es valido revise su ouija de confianza para más información.", ex.Message);
        }

        [Fact]
        public void Input_Contains_DiscardValues_Exception()
        {
            // Arrange
            IDiazService logicService = new DiazService();
            // Act
            var ex = Assert.Throws<Exception>(() => logicService.MySuperLogic(10, 22, 33, 44));

            // Assert
            Assert.Equal("Los números 13 y 10 causan un error por mala suerte.", ex.Message);
        }
    }
}
