using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class MachineTests
    {
        [TestMethod]
        public void TestEmptyMachine()
        {
            var machine = new Machine();
            machine.Run();
            Assert.AreEqual(1, machine.ISP);
        }

    }
}
