using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_Vehiculo.Clases
{
    //CLASE ABSTRACTA -->Sirve como base para poder crear otras clases...ya no podra ser instanciada
    public abstract class Vehiculo
    {
        //CONSTRUCTOR CON PARAMETROS
        public Vehiculo(string placa, string marca, string modelo)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
        }

        //CONSTRUCTOR SIN PARAMETROS
        public Vehiculo(){
            
        }
        //
        //metodo
        public virtual string Encender()//Es un metodo que se puede sobreescribir, ToString es un metodo virtual
        {
            return "Se enciende el motor";
        }

        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        
    }
}
