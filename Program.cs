using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using strategy;
using Interfaces;
using Classpersona;
using Classalumno;
using Classnumero;
using Microsoft.VisualBasic;
using MetodologíasDeProgramaciónI;
using ClassAlumnoAdaptable;
using ClassAlumnoEstudioso;
using Interfaces4;
using DecaradorDeLegajo;
using DecoradoDeNotas;
using EstadoDelAlumno;
using ClassRecuadroAsteriscos;


namespace ClasesMet
{
    class Program
//CLASE1
    {
        //Definicion de constantes y variables
        private static Random rdm = new Random();
        private const int DNImin= 10000;
        private const int DNImax= 99999;
        private const int LegajoMin= 100;
        private const int LegajoMax= 10000;
        private const int PromedioMin= 1;
        private const int PromedioMax= 10;



        //Funcion adicional para generar nombre aleatorio
        public static string NombreAleatorio()
        {
            List<string> nombre= new List<string>{"Tomas","Ramon","Felipe","Julian","Benjamin","Sam","Sarah","Jazmin","Tamara","Melody","Joel",
            "Gerardo", "Alex", "Brian", "Mariano", "Ezequiel","Anahi","Martina","Melina","Lucas","Geremias","Maria","Daiana","Nancy"};
            return nombre[rdm.Next(nombre.Count)];
        }

        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            int num=0;

            //Funcionamiento del adapter
            for (int i = 0; i < 10; i++)
            {
                Student student = new AlumnoAdaptable(new Alumno(NombreAleatorio(), rdm.Next(DNImin, DNImax),rdm.Next(LegajoMin,LegajoMax),rdm.Next(PromedioMin, PromedioMax), num));
                teacher.goToClass(student);
            }

            for (int i = 0; i < 10; i++)
            {
                Student student = new AlumnoAdaptable(new AlumnoMuyEstudioso(NombreAleatorio(),rdm.Next(DNImin, DNImax),rdm.Next(LegajoMin,LegajoMax),rdm.Next(PromedioMin, PromedioMax), num));
                teacher.goToClass(student);
            }

            teacher.teachingAClass();



           /* //Funcionamiento del decorator
            for (int i = 0; i < 10; i++)
            {
                IAlumno alumno = new Alumno(NombreAleatorio(), rdm.Next(DNImin, DNImax), rdm.Next(LegajoMin, LegajoMax), rdm.Next(PromedioMin, PromedioMax), num);
                IAlumno decorador = new DecoradorLegajo(alumno);
                IAlumno decorador1 = new DecoradoNotasEnLetras(decorador);
                IAlumno decorador2 = new EstadoAlumno(decorador1);
                IAlumno decorador3 = new RecuadroAstericos(decorador2);
                Student student = new AlumnoAdaptable(decorador3);
                teacher.goToClass(student);
            }

            for (int i = 0; i < 10; i++)
            {
                IAlumno alumnoEstudioso = new AlumnoMuyEstudioso(NombreAleatorio(), rdm.Next(DNImin, DNImax), rdm.Next(LegajoMin, LegajoMax), rdm.Next(PromedioMin, PromedioMax), num);
                IAlumno decorador = new DecoradorLegajo(alumnoEstudioso);
                IAlumno decorador1 = new DecoradoNotasEnLetras(decorador);
                IAlumno decorador2 = new EstadoAlumno(decorador1);
                IAlumno decorador3 = new RecuadroAstericos(decorador2);
                Student student = new AlumnoAdaptable(decorador3);
                teacher.goToClass(student);
            }

            teacher.teachingAClass();*/
            

        }

    }

}

