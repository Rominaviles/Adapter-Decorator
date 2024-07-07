using System;
using System.Collections.Generic;
using AlumnoDecorador;
using Interfaces4;

namespace ClassRecuadroAsteriscos
{
    public class RecuadroAstericos : DecoratorAlumno
    {
        public RecuadroAstericos(IAlumno alum) : base(alum){}

        public override string MostrarCalificacion()
        {
            string resultado= base.MostrarCalificacion();
            string lineaRecuadro = "*************************************";
            return lineaRecuadro + "\n" + resultado + "\n" + lineaRecuadro;
        }

    }
}