using System;

namespace WM
{
    public class PushDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
           
            if (instruction.Register == Machine.Registers.EAX)
                machine.Memory[machine.SBP++] = machine.EAX;

            if (instruction.Register == Machine.Registers.EBX)
                machine.Memory[machine.SBP++] = machine.EBX;
        }
    }
}