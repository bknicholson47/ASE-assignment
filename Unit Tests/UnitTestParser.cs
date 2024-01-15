using Microsoft.VisualStudio.TestPlatform.Utilities;
using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestParser
    { 
        [TestMethod]
        public void isNotNull()// done
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);

            // act
            Parser p = new Parser(bmG, pen);

            // assert
            Assert.IsNotNull(p);
        }
        [TestMethod]
        public void varCommand()// done
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);
            string output;
            // act
            Parser p = new Parser(bmG, pen);

            // assert
            p.ParseCommand("var Test = 1337", " ", false, 0);
            output = p.ParseCommand("varprint Test", "", false, 0);
            Assert.AreEqual("\nVariable 'Test' = 1337", output);
        }
        [TestMethod]
        public void MethodsCommand()// done
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);

            // act
            Parser p = new Parser(bmG, pen);

            // assert
            Assert.IsNotNull(p);
        }
        [TestMethod]
        public void LoopCommand()// done
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);
            string output;
            string progwindow = 
                "var a = 10" +
                "\nloop 5" +
                "\nvar a = a + 10" +
                "\nendloop";

            // act
            Parser p = new Parser(bmG, pen);
            p.ParseCommand("run", progwindow, false, 0);
            output = p.ParseCommand("varprint a", progwindow, false, 0);

            // assert
            Assert.AreEqual("\nVariable 'a' = 70", output);
        }
        [TestMethod]
        public void ifCommand()// done
        {
            // arrange
            Bitmap myBitmap = new Bitmap(600, 500);
            userPen pen = new userPen(Color.Black, 0, 0, 1, true);
            Graphics bmG;
            bmG = Graphics.FromImage(myBitmap);

            // act
            Parser p = new Parser(bmG, pen);

            // assert
            Assert.IsNotNull(p);
        }
    }
}