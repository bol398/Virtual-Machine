namespace WM
{
    internal class StoreDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
            if (instruction.Register == Machine.Registers.EAX)
                machine.Memory[instruction.Data] = machine.EAX;

            if (instruction.Register == Machine.Registers.EBX)
                machine.Memory[instruction.Data] = machine.EBX;
        }
    }
}