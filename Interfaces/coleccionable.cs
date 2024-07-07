using System;
using System.Collections.Generic;   

namespace Interfaces
{
    //ACTIVIDAD 1, ejercicio 3
    public interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene (Comparable c);

    }
}