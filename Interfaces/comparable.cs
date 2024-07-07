using System;
using System.Collections.Generic;   

namespace Interfaces
{
    //ACTIVIDAD 1, ejercicio 1
    public interface Comparable //public en la interface
    {
        bool sosIgual(Comparable c);
        bool sosMenor(Comparable c);
        bool SosMayor(Comparable c);
    }

}