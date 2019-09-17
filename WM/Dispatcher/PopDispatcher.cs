using System;

namespace WM
{
    public class PopDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
           
            if (instruction.Register == Machine.Registers.EAX)
                machine.EAX = machine.Memory[machine.SBP--];

            if (instruction.Register == Machine.Registers.EBX)
                machine.EBX = machine.Memory[machine.SBP--];
        }
    }
}