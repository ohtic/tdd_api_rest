using System.Net;
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
            var res = logicService.MySuperLogic(1, 2, 3, 4);

            // Assert
            Assert.Equal(4, res);
        }
    }
}
