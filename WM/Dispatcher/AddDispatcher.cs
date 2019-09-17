namespace WM
{
    internal class AddDispatcher : IDispatcher
    {
        public void Dispatch(Machine machine, Instruction instruction)
        {
            machine.EAX += machine.EBX;
        }
    }
}