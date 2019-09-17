using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WM
{
    // Detta är vår dispatcher för instruktionen "Move", dvs den klass som faktiskt utför Move
    // Notera att det står " : IDispatcher" efter klassnamnet. Detta betyder att klassen implementerar
    // interfacet IDispatcher, och då måste ha metoden "public void Dispatch(Machine machine, Instruction instruction)"
    // Pröva att byta namn på metoden nedan (eller lägg till/ta bort parametrar). Ni kommer då att se att det blir fel.
    // eftersom den metoden är deklarerad i IDispatcher-interfacet i filen "IDispatcher.cs"
    // I klassen som implementerar ett interface måste vi ha kod för metoden som utför något.
    public class MoveDispatcher : IDispatcher
    {
        /// <summary>
        /// Metoden som utför instruktionen "Move", dvs tar det som finns lagrat i fältet "Data" i parametern "instruction" och
        /// lagrar det i registret som anges i fältet "Register" i samma parameter. Registret finns i klassen "Machine"
        /// </summary>
        /// <param name="machine">Maskinen som innehåller registret som ska uppdateras</param>
        /// <param name="instruction">Instruktionen som berättar vilken data som ska skrivas i registret, och vilket register det ska skrivas i</param>
        public void Dispatch(Machine machine, Instruction instruction)
        {
            // Det här är naturligtvis inte så snyggt. Vi kommer att refaktorisera det här senare.
            if (instruction.Register == Machine.Registers.EAX)  // Om det angivna registret är EAX
                machine.EAX = instruction.Data;                 // ... så lagra data i registret EAX
            if (instruction.Register == Machine.Registers.EBX)  // och om det angivna registret är EBX
                machine.EBX = instruction.Data;                 // ... så lagra data där istälet
        }

       
    }
}
