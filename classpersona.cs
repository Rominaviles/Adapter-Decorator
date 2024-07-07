using System;
using System.Collections.Generic;
using Interfaces;

namespace Classpersona
{//Actividad 1, ejercicio 11
    public class Persona: Comparable
    {
        private string nombre; //Atributo
        private int dni; //Atributo

        public Persona(string n, int d) //Constructor
        {
            this.nombre=n;
            this.dni=d;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getDNI()
        {
            return this.dni;
        }
        public override string ToString()
        {
           return "Nombre: "+ getNombre() + "Dni: " + getDNI();
        }


        //Metodos de la interface Comparable
        public virtual bool sosIgual(Comparable c)
        {
            return this.dni == ((Persona)c).getDNI();
        }
        public virtual bool sosMenor(Comparable c)
        {
            return this.dni < ((Persona)c).getDNI();
        }
        public virtual bool SosMayor(Comparable c)
        {
            return this.dni > ((Persona)c).getDNI();
        }

    }
}