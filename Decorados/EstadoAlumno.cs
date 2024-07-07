using System;
using System.Collections.Generic;
using AlumnoDecorador;
using Interfaces4;

namespace EstadoDelAlumno
{
    public class EstadoAlumno : DecoratorAlumno
    {
        public EstadoAlumno(IAlumno alum) : base(alum){}

        public override string MostrarCalificacion()
        {
            string estado ="";
            int resultado = base.getCalificacion();
            if (resultado >=7)
            {
                estado = " PROMOCION ";
            }
            else if (resultado <=6 && resultado >=4)
            {
                estado = " APROBADO ";
            }

            else
            {
                estado = " DESAPROBADO ";
            }

            return resultado + estado;
        }


    }
}