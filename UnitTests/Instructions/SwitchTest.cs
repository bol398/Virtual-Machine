using Microsoft.VisualStudio.TestTools.UnitTesting;
using WM;

namespace UnitTests
{
    [TestClass]
    public class SwitchTest
    {

        [TestMethod]
        public void TestSwitch()
        {
            var machine = new Machine();
            // anta att "code" ligger i eax
            machine.EAX = 0;
            machine.Memory[0] = 1; // Move
            machine.Memory[1] = 4;
            machine.Memory[2] = 1; // EBX
            machine.Memory[3] = 4; // Multiply
            machine.Memory[4] = 1; // Move
            machine.Memory[5] = 9;
            machine.Memory[6] = 1; // EBX
            machine.Memory[7] = 6; // ADD
            machine.Memory[8] = 5; // JUMP
            machine.Memory[9] = 1; // Move
            machine.Memory[10] = 10;
            machine.Memory[11] = 0; // Eax
            machine.Memory[12] = 0;
            machine.Memory[13] = 1; // Move
            machine.Memory[14] = 14;
            machine.Memory[15] = 0; // Eax
            machine.Run();
            Assert.AreEqual(10, machine.EAX);
        }
    }
}
