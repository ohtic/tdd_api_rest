using TddApp;

namespace TddWebAppTest
{
    // TDD
    public class VenturaLogicServiceTest
    {
        private readonly VenturaService _service;

        public VenturaLogicServiceTest()
        {
            _service = new VenturaService();
        }

        [Fact]
        public void Get_ResultOK()
        {

            // Arrange
            var result = _service.MySuperLogic(5,8,11,20);

            // Asserts
            Assert.Equal(result, 16);

        }

        [Fact]
        public void Get_ExceptionIncorrectFormat() 
        {
            // Arrange
            var ex = Assert.Throws<Exception>(() => _service.MySuperLogic(1, 2, 23, 20000));

            // Asserts
            Assert.Equal("El valor solo puede ser un int de m�ximo 4 cifras.", ex.Message);
        }

        [Fact]
        public void Get_ExceptionDuplicateNumbers()
        {

            // Arrange
            var ex = Assert.Throws<Exception>(() => _service.MySuperLogic(1, 2, 2, 20));

            // Asserts
            Assert.Equal("Los n�meros no pueden estar duplicados.", ex.Message);

        }

        [Fact]
        public void Get_ExceptionRestrictedNumber13or10()
        {
            // Arrange
            var ex = Assert.Throws<Exception>(() => _service.MySuperLogic(13, 8, 10, 20));

            // Asserts
            Assert.Equal("Los n�meros 13 y 10 causan un error por mala suerte.", ex.Message);
        }


        [Fact]
        public void Get_ExceptionRestrictedNumber666()
        {
            // Arrange
            var ex = Assert.Throws<Exception>(() => _service.MySuperLogic(666, 8, 11, 20));

            // Asserts
            Assert.Equal("El n�mero 666 no es valido revise su ouija de confianza para m�s informaci�n.", ex.Message);

        }

        [Fact]
        public void Get_ExceptionNumber0IsNotInRange()
        {

            // Arrange
            var ex = Assert.Throws<Exception>(() => _service.MySuperLogic(0, 8, 10, 20));

            // Asserts
            Assert.Equal("El n�mero 0 es inv�lido, los n�meros deben estar entre 1 y 9999.", ex.Message);
        }


        [Fact]
        public void Get_ExceptionResultIsEqualToOneOfTheNumbersEntered()
        {
            // Arrange
            var ex = Assert.Throws<Exception>(() => _service.MySuperLogic(1, 8, 11, 20));

            // Asserts
            Assert.Equal("El resultado de la operaci�n final debe ser diferente a los cuatro n�meros introducidos.", ex.Message);

        }
    }
}
