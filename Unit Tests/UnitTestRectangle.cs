using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestRectangle
    {
        [TestMethod]
        public void Test()
        {
            // arrange
            var i = 50;
            var f = 50;
            var e = 50;
            var g = 50;

            // act
            Software_assignment.Rectangle c = new Software_assignment.Rectangle(i, f, e, g);

            // assert
            Assert.IsNotNull(c);
        }
    }
}