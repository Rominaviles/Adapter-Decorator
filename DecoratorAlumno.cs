using System;
using System.Collections.Generic;
using Interfaces4;
using Interfaces;

namespace AlumnoDecorador
{
    public class DecoratorAlumno : IAlumno
    {
        IAlumno alumnoDecorado;

        public DecoratorAlumno(IAlumno alum)
        {
            alumnoDecorado = alum;
        }
        public string getNombre()
        {
            return alumnoDecorado.getNombre();
        }

        public int getLegajo()
        {
            return alumnoDecorado.getLegajo();
        }
        public int getPromedio()
        {
            return alumnoDecorado.getPromedio();
        }

        public int getDNI()
        {
            return alumnoDecorado.getDNI();
        }
        public int getCalificacion()
        {
            return alumnoDecorado.getCalificacion();
        }
        public void setCalificacion(int calificacion)
        {
            alumnoDecorado.setCalificacion(calificacion);
        }
        public int responderPregunta(int pregunta)
        {
            return alumnoDecorado.responderPregunta(pregunta);
        }

        public virtual string MostrarCalificacion()
        {
            return alumnoDecorado.getNombre() + " "+ alumnoDecorado.MostrarCalificacion();
        }

        public bool sosIgual(Comparable c)
        {
            return alumnoDecorado.sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            return alumnoDecorado.sosMenor(c);
        }
        public bool SosMayor(Comparable c)
        {
            return alumnoDecorado.SosMayor(c);
        }
    }
}