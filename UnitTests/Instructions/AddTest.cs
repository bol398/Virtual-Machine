using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class AddTest
    {

        [TestMethod]
        public void TestAdd()
        {
            var machine = new Machine();
            machine.Memory[0] = 6;
            machine.EAX = 5;
            machine.EBX = 4;
            machine.Run();
            Assert.AreEqual(9, machine.EAX);
        }
    }
}
