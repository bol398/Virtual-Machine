using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class LoadTest
    {

        [TestMethod]
        public void TestLoadEAX()
        {
            var machine = new Machine();
            machine.Memory[32] = 64;
            machine.Memory[0] = 9;
            machine.Memory[1] = 32;
            machine.Memory[2] = 0;
            machine.Run();
            Assert.AreEqual(64, machine.EAX);
        }
        [TestMethod]
        public void TestLoadEBX()
        {
            var machine = new Machine();
            machine.Memory[32] = 64;
            machine.Memory[0] = 9;
            machine.Memory[1] = 32;
            machine.Memory[2] = 1;
            machine.Run();
            Assert.AreEqual(64, machine.EBX);
        }
    }
}
