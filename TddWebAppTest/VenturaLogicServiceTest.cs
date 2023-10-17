using System.Net;
using TddApp;
using TddWebApp;

namespace TddWebAppTest
{
    public class VenturaLogicServiceTest
    {
        [Fact]
   public void Get_ValidInput_ReturnsJsonResult()
    {
        // Arrange
        var venturaServiceMock = new Mock<VenturaService>();
        venturaServiceMock.Setup(s => s.MySuperLogic(1, 2, 3, 4)).Returns(4);

        var controller = new NumericControlController(venturaServiceMock.Object);
        controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext()
        };

        // Act
        var result = controller.Get(1, 2, 3, 4);

        // Assert
        var jsonResult = Assert.IsType<JsonResult>(result);
        var data = Assert.IsType<int>(jsonResult.Value);
        Assert.Equal(4, data);
    }
    }
}
