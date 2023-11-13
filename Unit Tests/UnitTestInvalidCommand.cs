using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestInvalidCommand
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
            var output = p.ParseCommand("cloer", "", false);

            // assert
            Assert.AreEqual("\ncloer not recognised", output);
        }
    }
}