using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestRunProgram
    { 
        [TestMethod]
        public void isNotNull()
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);

            // act
            Parser p = new Parser(bmG,pen);

            // assert
            Assert.IsNotNull(p);
        }
    }
}