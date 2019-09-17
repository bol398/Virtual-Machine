using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class StoreTest
    {

        [TestMethod]
        public void TestStoreEAX()
        {
            var machine = new Machine();
            machine.EAX = 64;

            machine.Memory[0] = 10;
            machine.Memory[1] = 32;
            machine.Memory[2] = 0;
            machine.Run();
            Assert.AreEqual(64, machine.Memory[32]);
        }
        [TestMethod]
        public void TestStoreEBX()
        {
            var machine = new Machine();
            machine.EBX = 64;

            machine.Memory[0] = 10;
            machine.Memory[1] = 32;
            machine.Memory[2] = 1;
            machine.Run();
            Assert.AreEqual(64, machine.Memory[32]);
        }
    }
}
