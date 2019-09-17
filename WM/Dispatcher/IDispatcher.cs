using System;
using System.Collections.Generic;
using System.Text;

namespace WM
{
    // Detta är ett interface, inte en klass. 
    // Notera att interface innehåller deklarationer av funktioner, i det här fallet Dispatch,
    // men metoderna är inte impementerade - de innehåller ingen kod. Vi kan inte instansiera interface (dvs "var x = new IDispatcher()" kommer inte att funka).
    // utan ett interface beskriver bara vilka metoder en klass som implementerar interfacet ska implementera.
    // Detta betyder att alla klasser som implementerar interfacet IDispatcher måste ha en metod som ser ut som
    // metoden Dispatch nedan, fast med en "kropp", en implementation av metoden som gör något.
    // Läs mer i klassen Machine
    public interface IDispatcher
    {
        void Dispatch(Machine machine, Instruction instruction);
    }
}
