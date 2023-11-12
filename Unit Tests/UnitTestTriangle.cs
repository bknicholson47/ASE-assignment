using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void isNotNull()
        {
            // arrange
            var i = 50;
            var f = 50;
            var e = 50;
            var i2 = 50;
            var f2 = 50;
            var e2 = 50;

            // act
            Triangle t = new Triangle(i, f, e, i2, f2, e2);
            
            // assert
            Assert.IsNotNull(t);
        }
    }
}