using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestRunProgram
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
            string programbox = "command input";

            // act
            var output = p.ParseCommand("run", programbox, false);

            // assert
            Assert.AreNotEqual("", output);
        }
    }
}