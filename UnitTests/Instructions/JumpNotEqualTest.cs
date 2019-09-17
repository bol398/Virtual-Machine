using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class JumpNotEqualTest
    {

        [TestMethod]
        public void TestJumpNotEqualSr0()
        {
            var machine = new Machine();
            machine.Memory[0] = 3;
            machine.Memory[1] = 10;
            machine.Run();
            Assert.AreEqual(3, machine.ISP);
        }

        [TestMethod]
        public void TestJumpNotEqualSr2()
        {
            var machine = new Machine();
            machine.Memory[0] = 3;
            machine.Memory[1] = 10;
            machine.SR = 2;
            machine.Run();
            Assert.AreEqual(11, machine.ISP);
        }

        [TestMethod]
        public void TestCompareCompareAndJump()
        {
            var machine = new Machine();
            machine.Memory[0] = 1;
            machine.Memory[1] = 10;
            machine.Memory[2] = 0;
            machine.Memory[3] = 1;
            machine.Memory[4] = 5;
            machine.Memory[5] = 1;
            machine.Memory[6] = 2;
            machine.Memory[7] = 3;
            machine.Memory[8] = 10;
            machine.Run();
            Assert.AreEqual(11, machine.ISP);
        }
    }
}
