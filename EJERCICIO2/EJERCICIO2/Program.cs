using System;
using System.Collections.Generic;
using EJERCICIO2.Clases;


namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("001","Natalia","Proaño City", new DateTime(2001/01/31),new List<Matricula>());

            Clase clase = new Clase("Fìsica",1,"D","Ing. Bermudez", new List<Matricula>());

            Matricula matricula = new Matricula(1, new DateTime(2019/05/18),estudiante, new List<Clase>());

            Console.WriteLine(matricula.Estudiante.Nombre);
            Console.WriteLine(matricula.Estudiante.Direccion);

            Console.Read();
        }
    }
}
