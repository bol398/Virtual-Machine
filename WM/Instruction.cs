using System;
using System.Collections.Generic;
using System.Text;

namespace WM
{
    public class Instruction
    {
        public enum InstructionType
        {
            Halt,
            Add,
            Subtract,
            Multiply,
            Move,
            Push,
            Pop,
            Compare,
            JumpNotEqual,
            Jump,
            Load,
            Store
        };

        public InstructionType Operation;                          
        public byte Data;                                        
        public Machine.Registers Register;                        
        public IDispatcher Dispatcher;                        
    }
}
