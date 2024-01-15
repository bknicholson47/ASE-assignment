using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestFill
    { 
        [TestMethod]
        public void isNotNull()
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Parser p = new Parser(bmG, pen);

            // act
            p.ParseCommand("fill off", "", false, 0);

            // assert
            Assert.AreEqual(false, pen.getFill());
        }
    }
}