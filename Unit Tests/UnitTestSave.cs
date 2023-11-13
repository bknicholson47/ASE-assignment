using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestSave
    { 
        [TestMethod]
        public void Test()
        {
            // arrange
            var programbox = "this is a dummy file";
            var FileName = "./TestSave.txt";

            // act
            File.WriteAllText(FileName, programbox);

            // assert
            Assert.AreEqual(programbox, File.ReadAllText(FileName));
        }
    }
}