using System;
using System.Collections.Generic;
using AlumnoDecorador;
using Interfaces4;

namespace DecaradorDeLegajo
{
    public class DecoradorLegajo : DecoratorAlumno       
    {
        public DecoradorLegajo(IAlumno alum) : base(alum){}

        public override string MostrarCalificacion()
        {
            string resultado =base.MostrarCalificacion();
            resultado += getLegajo();
            return resultado;
        }


    }
}