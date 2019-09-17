namespace WM
{
    internal class JumpNotEqualDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
            var equals = machine.SR & 2;
            if (equals != 0)
                machine.ISP = instruction.Data;
        }
    }
}