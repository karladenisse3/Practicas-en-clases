using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_Vehiculo.Clases
{
    public class Bus:Vehiculo
    {
        //CONSTRUCTOR DEL HIJO
        public Bus(string placa, string marca, string modelo, int numeroDePasajeros,
            string estilo) : base(placa,marca,modelo)
        {
            NumeroDePasajeros = numeroDePasajeros;
            Estilo = estilo;
        }

        private int numeroDePasajeros;

        public int NumeroDePasajeros
        {
            get { return numeroDePasajeros; }
            set { numeroDePasajeros = value; }
        }

        private string estilo;

        public  string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }
        /*
        public new string Encender()//Ocultarlo el warnning...Es una forma de implementar la herencia
        {
            return "Se enciende el motor del bus";
        }
        */

          /*  //Todos los metodos que aparecen en la clase virtual apareceran aqui en override
        public override string Encender()

        {
            return base.Encender()+ " del bus";
        }
        */
        public override string Encender()

        {
            return base.Encender() + " del bus";
        }
        //METODO
        public string SubirPasajeros()
        {
            return "Subiendo pasajeros" ;
        }
    }
}
