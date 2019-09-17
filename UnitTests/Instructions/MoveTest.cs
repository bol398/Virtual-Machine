using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class MoveTest
    {

        [TestMethod]
        public void TestMoveEAXMachine()
        {
            var machine = new Machine();
            machine.Memory[0] = 1;
            machine.Memory[1] = 10;
            machine.Memory[2] = 0;
            machine.Run();
            Assert.AreEqual(10, machine.EAX);
        }

        [TestMethod]
        public void TestMoveEBXMachine()
        {
            var machine = new Machine();
            machine.Memory[0] = 1;
            machine.Memory[1] = 10;
            machine.Memory[2] = 1;
            machine.Run();
            Assert.AreEqual(10, machine.EBX);
        }
    }
}
