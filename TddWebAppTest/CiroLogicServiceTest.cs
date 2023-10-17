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
    }
}