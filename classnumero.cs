using System;
using System.Collections.Generic;
using Interfaces;

namespace Classnumero
{//Actividad 1, ejercicio 2
    public class Numero: Comparable
    {
        private int valor; //Atributo

        public Numero (int v) //Constructor
        {
            this.valor=v;
        }

        public int getValor()
        {
            return this.valor;
        }

        public override string ToString()
        {
            return this.valor.ToString();
        }

        //METODOS INTERFACE COMPARABLE
        public bool sosIgual(Comparable c)
        {
            return this.valor == ((Numero)c).getValor();
        }
        public bool sosMenor(Comparable c)
        {
            return this.valor < ((Numero)c).getValor();
        }
        public bool SosMayor(Comparable c)
        {
            return this.valor > ((Numero)c).getValor();
        }
        
    }
}