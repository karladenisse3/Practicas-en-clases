using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO2.Clases
{
    public class Clase
    {
        //CONSTRUCTOR
        public Clase(string asignatura, int nivel, string paralelo, string docente, List<Matricula> listamatricula)
        {
            Asignatura = asignatura;
            Nivel = nivel;
            Paralelo = paralelo;
            Docente = docente;
            Listamatricula = listamatricula;
        }

        private string asigantura;

        public string Asignatura
        {
            get { return asigantura; }
            set { asigantura = value; }
        }

        private int nivel;

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        private string paralelo;

        public string Paralelo
        {
            get { return paralelo; }
            set { paralelo = value; }
        }

        private string docente;

        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        private List<Matricula> listamatricula;

     

        public List<Matricula> Listamatricula
        {
            get { return listamatricula; }
            set { listamatricula = value; }
        }





    }
}
