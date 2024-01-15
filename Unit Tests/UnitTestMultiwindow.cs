using Software_assignment;
using System.Drawing;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTestMultiwindow
    {
        [TestMethod]
        public void Test()
        {
            // arrange
            Form1 form1 = new Form1();
            // act
            form1.newProgWind_Click(null, null);
            // assert
            //void function returns nothing will throw exeption on error
        }
    }
}