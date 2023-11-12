using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestRectangle
    {
        [TestMethod]
        public void isNotNull()
        {
            // arrange
            var i = 50;
            var f = 50;
            var e = 50;

            // act
            Circle c = new Circle(i, f, e);

            // assert
            Assert.IsNotNull(c);
        }
    }
}