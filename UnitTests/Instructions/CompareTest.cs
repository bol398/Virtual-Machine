using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class CompareTest
    {

        [TestMethod]
        public void TestCompareEquals()
        {
            var machine = new Machine();
            machine.Memory[0] = 1;
            machine.Memory[1] = 10;
            machine.Memory[2] = 0;
            machine.Memory[3] = 1;
            machine.Memory[4] = 10;
            machine.Memory[5] = 1;
            machine.Memory[6] = 2;
            machine.Run();
            Assert.AreEqual(0, machine.SR);
        }

        [TestMethod]
        public void TestCompareEaxLessThanEbx()
        {
            var machine = new Machine();
            machine.Memory[0] = 1;
            machine.Memory[1] = 5;
            machine.Memory[2] = 0;
            machine.Memory[3] = 1;
            machine.Memory[4] = 10;
            machine.Memory[5] = 1;
            machine.Memory[6] = 2;
            machine.Run();
            Assert.AreEqual(2, machine.SR);
        }

        [TestMethod]
        public void TestCompareEaxGreaterThanEbx()
        {
            var machine = new Machine();
            machine.Memory[0] = 1;
            machine.Memory[1] = 10;
            machine.Memory[2] = 0;
            machine.Memory[3] = 1;
            machine.Memory[4] = 5;
            machine.Memory[5] = 1;
            machine.Memory[6] = 2;
            machine.Run();
            Assert.AreEqual(3, machine.SR);
        }
    }
}
