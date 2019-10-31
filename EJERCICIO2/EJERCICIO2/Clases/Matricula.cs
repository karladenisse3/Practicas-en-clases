using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO2.Clases
{
    public class Matricula
    {
        //constructor
        public Matricula(int numero, DateTime fecha, Estudiante estudiante, List<Clase> listaclase)
        {
            Numero = numero;
            Fecha = fecha;
            Estudiante = estudiante;
            Listaclase = listaclase;
        }

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Estudiante estudiante;//Relaciòn con estudiante (UNO A MUCHOS)

        public Estudiante Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }

        
   
        private List<Clase> listaclase;//tipo arreglo



        public List<Clase> Listaclase
        {
            get { return listaclase; }
            set { listaclase = value; }
        }

        //ESTAS CLASES YA ESTAN DEFINIDAS Y TIENEN LO BASICO CON CONSTRUCTOR

    }
}
