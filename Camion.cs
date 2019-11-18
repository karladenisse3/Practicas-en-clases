using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_Vehiculo.Clases
{
    public class Camion:Vehiculo
    {
        private int cargaSoportada;

        public Camion(string placa, string marca, string modelo, int cargaSoporta, 
            string tipoDeCabina) : base(placa,marca,modelo)
        {
            CargaSoporta = cargaSoporta;
            TipoDeCabina = tipoDeCabina;
        }

        public int CargaSoporta
        {
            get { return cargaSoportada; }
            set { cargaSoportada = value; }
        }

        private string tipoDeCabina;

        public string TipoDeCabina
        {
            get { return tipoDeCabina; }
            set { tipoDeCabina = value; }
        }

        public override string Encender()

        {
            return base.Encender() + " del camion";
        }

    }
}
