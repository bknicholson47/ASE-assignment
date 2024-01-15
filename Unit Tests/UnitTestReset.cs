using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestReset
    { 
        [TestMethod]
        public void Test()
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Parser p = new Parser(bmG, pen);
            p.ParseCommand("moveto 50 50", "", false, 0);

            Bitmap myBitmap2 = new Bitmap(600, 500);
            Graphics bmG2;
            bmG2 = Graphics.FromImage(myBitmap2);
            userPen pen2 = new userPen(Color.Black, 0, 0, 1, true);
            pen2.drawTo(bmG2, 25, 25);

            // act
            p.ParseCommand("reset", "", false, 0);
            p.ParseCommand("drawto 25 25", "", false, 0);



            // assert
            Assert.AreEqual(myBitmap2.GetPixel(1,1), myBitmap.GetPixel(1,1));
        }
    }
}