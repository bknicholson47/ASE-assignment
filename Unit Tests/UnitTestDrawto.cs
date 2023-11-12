using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestDrawto
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
            p.ParseCommand("drawto 10 10", "", false);

            // assert
            Assert.AreNotEqual(new Bitmap(600, 500), myBitmap);
        }
    }
}