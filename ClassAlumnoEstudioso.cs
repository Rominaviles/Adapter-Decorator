using System;
using System.Collections.Generic;
using Classalumno;


//Ejercicio 2. act 4
namespace ClassAlumnoEstudioso
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string n, int d, int l, int p, int calif) : base (n, d, l, p, calif)
        {
            
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}