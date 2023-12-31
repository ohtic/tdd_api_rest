﻿using System.Net;
using TddApp;
using TddWebApp;

namespace TddWebAppTest
{
    public class EsteveLogicServiceTest
    {
        [Fact]
        public void Get_OK()
        {
            // Arrange
            EsteveService logicService = new EsteveService();

            // Act
            var res = logicService.MySuperLogic(1, 20, 300, 4000);

            // Assert
            Assert.Equal(4000, res);
        }


        [Fact]
        public void Get_InvalidNumbers_ReturnException()
        {
            // Arrange
            EsteveService logicService = new EsteveService();

            // Act
            // Assert
            Exception exception = Assert.Throws<Exception>(() => logicService.MySuperLogic(12000, 2, 30, 400));
            Assert.Equal("El valor solo puede ser un int de máximo 4 cifras.", exception.Message);
        }

        [Fact]
        public void Get_DuplicateNumbers_ReturnException()
        {
            // Arrange
            EsteveService logicService = new EsteveService();

            // Act
            // Assert
            Exception exception = Assert.Throws<Exception>(() => logicService.MySuperLogic(2, 2, 30, 400));
            Assert.Equal("Los números no pueden estar duplicados.", exception.Message);
        }

        [Fact]
        public void Get_666Input_ReturnException()
        {
            // Arrange
            EsteveService logicService = new EsteveService();

            // Act
            // Assert
            Exception exception = Assert.Throws<Exception>(() => logicService.MySuperLogic(666, 20, 3, 4000));
            Assert.Equal("El número 666 no es valido revise su ouija de confianza para más información.", exception.Message);
        }

        [Fact]
        public void Get_13Input_ReturnException()
        {
            // Arrange
            EsteveService logicService = new EsteveService();

            // Act
            // Assert
            Exception exception = Assert.Throws<Exception>(() => logicService.MySuperLogic(13, 2, 300, 4000));
            Assert.Equal("Los números 13 y 10 causan un error por mala suerte.", exception.Message);
        }

        [Fact]
        public void Get_NegativeInput_ReturnException()
        {
            // Arrange
            EsteveService logicService = new EsteveService();

            // Act
            // Assert
            Exception exception = Assert.Throws<Exception>(() => logicService.MySuperLogic(-1, 20, 300, 4000));
            Assert.Equal($"El número -1 es inválido los números deben ser mayor o iguales a 1.", exception.Message);
        }

        [Fact]
        public void Get_RepeatedDigitCount_ReturnException()
        {
            // Arrange
            EsteveService logicService = new EsteveService();

            // Act
            // Assert
            Exception exception = Assert.Throws<Exception>(() => logicService.MySuperLogic(2, 20, 300, 400));
            Assert.Equal($"Cada número debe tener un número diferente de cifras.", exception.Message);
        }
    }
}
