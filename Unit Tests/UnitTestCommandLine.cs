using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestCommandLine
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
            string textbox = "command input";

            // act
            var output = p.ParseCommand(textbox, "", false);

            // assert
            Assert.AreNotEqual("", output);
        }
    }
}