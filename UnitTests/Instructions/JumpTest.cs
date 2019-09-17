using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class JumpTest
    {

        [TestMethod]
        public void TestJump()
        {
            var machine = new Machine();
            machine.Memory[0] = 5;
            machine.EAX = 10;
            machine.Run();
            Assert.AreEqual(11, machine.ISP);
        }
    }
}
