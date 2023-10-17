using TddApp;

namespace TddWebAppTest
{
    public class CiroLogicServiceTest
    {
        [Fact]
        public void MySuperLogic()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var result = logicService.MySuperLogic(4, 24, 332, 5012);

            //Assert
            Assert.Equal(5009, result);
        }

        [Fact]
        public void Valor_solo_puede_ser_de_máximo_4_cifras_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(1, 24, 332, 50112));

            //Assert
            Assert.Equal(410, ex.Code);
            Assert.Equal("El valor solo puede ser un int de máximo 4 cifras", ex.Message);
        }

        [Fact]
        public void Numeros_no_pueden_estar_duplicados_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(1, 24, 332, 332));

            //Assert
            Assert.Equal(418, ex.Code);
            Assert.Equal("Los números no pueden estar duplicados", ex.Message);
        }

        [Fact]
        public void Numero_666_no_valido_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(1, 24, 666, 5012));

            //Assert
            Assert.Equal(450, ex.Code);
            Assert.Equal("El número 666 no es valido revise su ouija de confianza para más información", ex.Message);
        }

        [Fact]
        public void Numeros_13_y_10_no_validos_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(4, 13, 332, 5012));

            //Assert
            Assert.Equal(555, ex.Code);
            Assert.Equal("Los números 13 y 10 causan un error por mala suerte", ex.Message);
        }

        [Fact]
        public void Numeros_menores_a_1_no_validos_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(-1, 24, 332, 5012));

            //Assert
            Assert.Equal(400, ex.Code);
            Assert.Equal("El número -1 es inválido los números deben ser mayor o iguales a 1", ex.Message);
        }

        [Fact]
        public void Numero_debe_tener_cantidad_diferente_de_cifras_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(11, 24, 33, 50));

            //Assert
            Assert.Equal(432, ex.Code);
            Assert.Equal("Cada número debe tener una cantidad diferente de cifras", ex.Message);
        }

        [Fact]
        public void Resultado_debe_ser_diferente_a_los_numeros_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(1, 24, 332, 5012));

            //Assert
            Assert.Equal(411, ex.Code);
            Assert.Equal("El resultado de la operación final debe ser diferente a los cuatro números introducidos", ex.Message);
        }
    }
}