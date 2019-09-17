namespace WM
{
    public class CompareDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
            machine.SR &= 252;
            if (machine.EAX == machine.EBX)                
                return;
            machine.SR |= 2;
            if (machine.EAX > machine.EBX)
                machine.SR |= 1;
        }
    }
}