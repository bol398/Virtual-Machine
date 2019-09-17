using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class PushTest
    {

        [TestMethod]
        public void TestPushEAX()
        {
            var machine = new Machine();
            machine.EAX = 5;
            machine.Memory[0] = 7;
            machine.Memory[1] = 0;
            machine.Run();
            Assert.AreEqual(5, machine.Memory[128]);
        }
        [TestMethod]
        public void TestPushEBX()
        {
            var machine = new Machine();
            machine.EBX = 5;
            machine.Memory[0] = 7;
            machine.Memory[1] = 1;
            machine.Run();
            Assert.AreEqual(5, machine.Memory[128]);
        }
    }
}
