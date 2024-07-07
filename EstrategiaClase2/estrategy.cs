using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using ClasesMet;
using Classalumno;
using Interfaces;
using Interfaces4;

namespace strategy
{

    /*Strategy
    1)Crear interface
    2)Implementar subclases donde c/u tiene una estrategia distinta
    3)Modificacion de la clase(contexto) - crear composicion(Atributo)/crear estrategia (Constructor)
     mecanismo para cambiar estrategia (setter)
    4)Delegar la responsabilidad a otro objeto (Alumnos a estrategia)
    */
    //EJERCICIO 1
//Paso 1 de Strategy
    public interface EstrategiaComparacion
    {//Ponemos como parametro los dos alumnos que compara
        bool sosIgual(IAlumno c, IAlumno c1);
        bool sosMenor(IAlumno c, IAlumno c1);
        bool SosMayor(IAlumno c, IAlumno c1);
    }
//Paso 2 de strategy
    //Estrategia para comparar por promedio 
    public class EstrategiaPorPromedio: EstrategiaComparacion
    {
        public bool sosIgual(IAlumno c, IAlumno c1)
        {
            return c.getPromedio() == c1.getPromedio();
        }
        public bool sosMenor(IAlumno c, IAlumno c1)
        {
            return c.getPromedio() < c1.getPromedio();
        }
        public bool SosMayor(IAlumno c, IAlumno c1)
        {
            return c.getPromedio() > c1.getPromedio();
        }

        public string getNombre()
        {
            return getNombre();
        }
        public int getLegajo()
        {
            return getLegajo();
        }
        public int getPromedio()
        {
            return getPromedio();
        }
        public int getCalificacion()
        {
            return getCalificacion();
        }
        public void setCalificacion(int calificacion)
        {
            setCalificacion(calificacion);
        }
        public int responderPregunta(int pregunta)
        {
            return responderPregunta(pregunta);
        }
        public string MostrarCalificacion()
        {
            return MostrarCalificacion();
        }

    }

    //Estrategia para comparar por Legajo
    public class EstrategiaPorLegajo: EstrategiaComparacion
    {
        public bool sosIgual(IAlumno c, IAlumno c1)
        {
            return c.getLegajo() == c1.getLegajo();
        }
        public bool sosMenor(IAlumno c, IAlumno c1)
        {
            return c.getLegajo() < c1.getLegajo();
        }
        public bool SosMayor(IAlumno c, IAlumno c1)
        {
            return c.getLegajo() > c1.getLegajo();
        }

        public string getNombre()
        {
            return getNombre();
        }
        public int getLegajo()
        {
            return getLegajo();
        }
        public int getPromedio()
        {
            return getPromedio();
        }
        public int getCalificacion()
        {
            return getCalificacion();
        }
        public void setCalificacion(int calificacion)
        {
            setCalificacion(calificacion);
        }
        public int responderPregunta(int pregunta)
        {
            return responderPregunta(pregunta);
        }
        public string MostrarCalificacion()
        {
            return MostrarCalificacion();
        }
    }

    //Estrategia de comparacion por DNI
    public class EstrategiaPorDni: EstrategiaComparacion
    {
        public bool sosIgual(IAlumno c, IAlumno c1)
        {
            return c.getDNI() == c1.getDNI();
        }
        public bool sosMenor(IAlumno c, IAlumno c1)
        {
            return c.getDNI() < c1.getDNI();
        }
        public bool SosMayor(IAlumno c, IAlumno c1)
        {
            return c.getDNI() > c1.getDNI();
        }

        public string getNombre()
        {
            return getNombre();
        }
        public int getLegajo()
        {
            return getLegajo();
        }
        public int getPromedio()
        {
            return getPromedio();
        }
        public int getCalificacion()
        {
            return getCalificacion();
        }
        public void setCalificacion(int calificacion)
        {
            setCalificacion(calificacion);
        }
        public int responderPregunta(int pregunta)
        {
            return responderPregunta(pregunta);
        }
        public string MostrarCalificacion()
        {
            return MostrarCalificacion();
        }

    }

    //Estrategia de comparacion por Nombre
    //En mayor y menor lo compare por orden alfabetico.. o lo comparo por la cantidad de caracteres?
    public class EstrategiaPorNombre: EstrategiaComparacion
    {
        public bool sosIgual(IAlumno c, IAlumno c1)
        {
            return c.getNombre() == c1.getNombre();
        }
        public bool sosMenor(IAlumno c, IAlumno c1)//Al ser menor da un num neg
        {
            return string.Compare(c.getNombre(), c1.getNombre()) < 0;
        }
        public bool SosMayor(IAlumno c, IAlumno c1)//Al ser mayor da un num pos
        {
            return string.Compare(c.getNombre(), c1.getNombre()) > 0;
        }

        public string getNombre()
        {
            return getNombre();
        }
        public int getLegajo()
        {
            return getLegajo();
        }
        public int getPromedio()
        {
            return getPromedio();
        }
        public int getCalificacion()
        {
            return getCalificacion();
        }
        public void setCalificacion(int calificacion)
        {
            setCalificacion(calificacion);
        }
        public int responderPregunta(int pregunta)
        {
            return responderPregunta(pregunta);
        }
        public string MostrarCalificacion()
        {
            return MostrarCalificacion();
        }

        
    }

    //Ejercicio 5 (opcional) act4.
    public class EstrategiaporCalificacion: EstrategiaComparacion
    {
        public bool sosIgual(IAlumno c, IAlumno c1)
        {
            return c.getCalificacion() == c1.getCalificacion();
        }
        public bool sosMenor(IAlumno c, IAlumno c1)
        {
            return c.getCalificacion() < c1.getCalificacion();
        }
        public bool SosMayor(IAlumno c, IAlumno c1)
        {
            return c.getCalificacion() > c1.getCalificacion();
        }

        public string getNombre()
        {
            return getNombre();
        }
        public int getLegajo()
        {
            return getLegajo();
        }
        public int getPromedio()
        {
            return getPromedio();
        }
        public int getCalificacion()
        {
            return getCalificacion();
        }
        public void setCalificacion(int calificacion)
        {
            setCalificacion(calificacion);
        }
        public int responderPregunta(int pregunta)
        {
            return responderPregunta(pregunta);
        }
        public string MostrarCalificacion()
        {
            return MostrarCalificacion();
        }

    
    }
}
