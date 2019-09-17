using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class PopTest
    {
        
        [TestMethod]
        public void TestPopEAX()
        {
            var machine = new Machine();
            machine.Memory[128] = 5;
            machine.Memory[0] = 8;
            machine.Memory[1] = 0;
            machine.Run();
            Assert.AreEqual(5, machine.EAX);
        }
        [TestMethod]
        public void TestPopEBX()
        {
            var machine = new Machine();
            machine.Memory[128] = 5;
            machine.Memory[0] = 8;
            machine.Memory[1] = 1;
            machine.Run();
            Assert.AreEqual(5, machine.EBX);
        }
    }
}
