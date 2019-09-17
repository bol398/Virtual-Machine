using System;
using System.Collections.Generic;
using System.Text;

namespace WM
{
    
    public class Machine
    {
        public byte EAX;                        
        public byte EBX;                

        public byte SBP = 128;        
        public byte ISP = 0;                     
        public byte SR  = 0;         

        public byte[] Memory = new byte[256];       

        public enum Registers              
        {                                             
            EAX,                               
            EBX,                                       
            SPB,                       
            ISP,                                     
            SR,
            None
        }

       
        public void Run()
        {
            
            while(true)
            {
                
                var instruction = ReadInstruction();
                
                if (instruction.Operation == Instruction.InstructionType.Halt)
                    
                    break;
                instruction.Dispatcher.Dispatch(this, instruction);
            }
        }

        private Instruction ReadInstruction()
        {
           
            

            var firstByte = Memory[ISP++];
            var instruction = new Instruction();
            switch(firstByte)
            {
                case 0:            
                    instruction.Operation = Instruction.InstructionType.Halt;
                    break;
                case 1:                       
                    instruction.Operation = Instruction.InstructionType.Move;
                    instruction.Data = Memory[ISP++];
                    instruction.Register = GetRegister(Memory[ISP++]);
                    instruction.Dispatcher = new MoveDispatcher();
                    break;
                case 2:
                    instruction.Operation = Instruction.InstructionType.Compare;
                    instruction.Dispatcher = new CompareDispatcher();
                    break;
                case 3:
                    instruction.Operation = Instruction.InstructionType.JumpNotEqual;
                    instruction.Data = Memory[ISP++];
                    instruction.Dispatcher = new JumpNotEqualDispatcher();
                    break;
                case 4:
                    instruction.Operation = Instruction.InstructionType.Multiply;
                    instruction.Dispatcher = new MultiplyDispatcher();
                    break;
                case 5:
                    instruction.Operation = Instruction.InstructionType.Jump;
                    instruction.Data = Memory[ISP++];
                    instruction.Dispatcher = new JumpDispatcher();
                    break;
                case 6:
                    instruction.Operation = Instruction.InstructionType.Add;
                    instruction.Dispatcher = new AddDispatcher();
                    break;
                case 37:
                    instruction.Operation = Instruction.InstructionType.Push;
                    instruction.Register = GetRegister(Memory[ISP++]);
                    instruction.Dispatcher = new PushDispatcher();
                    break;
                case 8:
                    instruction.Operation = Instruction.InstructionType.Pop;
                    instruction.Register = GetRegister(Memory[ISP++]);
                    instruction.Dispatcher = new PopDispatcher();
                    break;
                case 9:
                    instruction.Operation = Instruction.InstructionType.Load;
                    instruction.Data = Memory[ISP++];
                    instruction.Register = GetRegister(Memory[ISP++]);
                    instruction.Dispatcher = new LoadDispatcher();
                    break;
                case 10:
                    instruction.Operation = Instruction.InstructionType.Store;
                    instruction.Data = Memory[ISP++];
                    instruction.Register = GetRegister(Memory[ISP++]);
                    instruction.Dispatcher = new StoreDispatcher();
                    break;

            }
           
            return instruction;
        }

        public Registers GetRegister(byte code)
        {
            switch (code)
            {
                case 0:
                    return Registers.EAX;
                case 1:
                    return Registers.EBX;
                default:                     
                    return Registers.None;
            }
        }
    }
}
