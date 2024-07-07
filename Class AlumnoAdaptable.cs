using System;
using System.Collections.Generic;
using Classalumno;
using Interfaces;
using Interfaces4;
using MetodologíasDeProgramaciónI;
using strategy;
//Ejercicio 3. implementacion del patron adapter. act4
namespace ClassAlumnoAdaptable
{
    public class AlumnoAdaptable : Student //objetivo
    {
        IAlumno alumno; //Adaptable
        private EstrategiaComparacion estrategia;

        public AlumnoAdaptable(IAlumno alum)
        {
            estrategia= new EstrategiaPorDni();
            this.alumno = alum;
        }

        //Implementacion de todos los metodos de student
		public string getName()
        {
            return alumno.getNombre() + " ";
        }
		public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }
		public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }
		public string showResult()
        {
            return alumno.MostrarCalificacion();
        }
      

		public bool equals(Student student)
        {
            return alumno.sosIgual((Comparable)((AlumnoAdaptable)student).alumno);
        }
		public bool lessThan(Student student)
        {
            return alumno.sosMenor((Comparable)((AlumnoAdaptable)student).alumno);
        }
		public bool greaterThan(Student student)
        {
            return alumno.SosMayor((Comparable)((AlumnoAdaptable)student).alumno);
        }
    }
}