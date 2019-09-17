namespace WM
{
    internal class MultiplyDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
            machine.EAX *= machine.EBX;
        }
    }
}