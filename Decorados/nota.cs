using System;
using System.Collections.Generic;
using AlumnoDecorador;
using Interfaces4;

namespace DecoradoDeNotas
{       
    public class DecoradoNotasEnLetras : DecoratorAlumno
    {
        public DecoradoNotasEnLetras(IAlumno alum) : base(alum){}
        public override string MostrarCalificacion()
        {
            string [] notas= new string [] {" CERO ", " UNO ", " DOS "," TRES "," CUATRO "," CINCO "," SEIS "," SIETE "," OCHO "," NUEVE "," DIEZ "};
            string resultado = base.MostrarCalificacion();
            resultado+=notas[getCalificacion()];
            return resultado;

        }


    }
}