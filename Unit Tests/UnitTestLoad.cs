using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestLoad
    {
        [TestMethod]
        public void Test()
        {
            // arrange
            var programbox = "";
            var FileName = "./TestSave.txt";

            // act
            programbox = File.ReadAllText(FileName);

            // assert
            Assert.AreEqual("this is a dummy file", programbox);
        }
    }
}