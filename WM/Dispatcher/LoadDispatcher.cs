namespace WM
{
    internal class LoadDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
            if (instruction.Register == Machine.Registers.EAX)
                machine.EAX = machine.Memory[instruction.Data];

            if (instruction.Register == Machine.Registers.EBX)
                machine.EBX = machine.Memory[instruction.Data];
        }
    }
}