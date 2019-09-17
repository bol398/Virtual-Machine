namespace WM
{
    public class JumpDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
            machine.ISP = machine.EAX;
        }
    }
}