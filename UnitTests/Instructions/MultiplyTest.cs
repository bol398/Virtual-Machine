using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class MultiplyTest
    {

        [TestMethod]
        public void TestMultiply()
        {
            var machine = new Machine();
            machine.Memory[0] = 4;
            machine.EAX = 5;
            machine.EBX = 4;
            machine.Run();
            Assert.AreEqual(20, machine.EAX);
        }
    }
}
