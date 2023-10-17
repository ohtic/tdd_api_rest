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
        public void Valor_solo_puede_ser_de_m�ximo_4_cifras_Exception()
        {
            //Arrance
            var logicService = new CiroService();

            //Act
            var ex = Assert.Throws<LogicValidationException>(() => logicService.MySuperLogic(1, 24, 332, 50112));

            //Assert
            Assert.Equal(410, ex.Code);
            Assert.Equal("El valor solo puede ser un int de m�ximo 4 cifras", ex.Message);
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
            Assert.Equal("Los n�meros no pueden estar duplicados", ex.Message);
        }
    }
}