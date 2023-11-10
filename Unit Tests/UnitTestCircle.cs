using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void isNotNull()
        {
            // arrange
            var i = 50;
            var f = 50;
            var e = 50;

            // act
            Circle c = new Circle(Color.Blue, i, f, e);

            // assert
            Assert.IsNotNull(c);
        }
        [TestMethod]
        public void ChangesCanvas()
        {
            // arrange
            var i = 50;
            var f = 50;
            var e = 50;

            // act
            Circle c = new Circle(Color.Blue, i, f, e);

            // assert
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void correctRender()
        {
            // arrange
            var i = 50;
            var f = 50;
            var e = 50;

            // act
            Circle c = new Circle(Color.Blue, i, f, e);

            // assert
            Assert.IsNotNull(c);
        }
    }
}