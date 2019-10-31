using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO2.Clases
{
    public class Estudiante
    {
        public Estudiante()
        {

        }

        //CONSTRUCTOR

        public Estudiante(string identificacion, string nombre, string direccion, DateTime fechadenacimiento, List<Matricula> listamatricula)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Direccion = direccion;
            Fechadenacimiento = fechadenacimiento;
            Listamatricula = listamatricula;
        }


        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

        public string  Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private DateTime fechadenacimiento;

        public DateTime Fechadenacimiento
        {
            get { return fechadenacimiento; }
            set { fechadenacimiento = value; }
        }

        //constructor
   
   

        private List<Matricula> listamatricula;
        
        public List<Matricula> Listamatricula
        {
            get { return listamatricula; }
            set { listamatricula = value; }
        }






    }
}
