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
            var ex = Assert.Throws<Exception>(() => logicService.MySuperLogic(1, 24, 332, 50112));

            //Assert
            Assert.Equal("El valor solo puede ser un int de máximo 4 cifras", ex.Message);
        }
    }
}