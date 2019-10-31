using System;
using System.Collections.Generic;
using System.Text;

namespace FIGURAGEOMETRICA.Clase_encapsulado
{
    public class FiguraGeometrica 
    {
        public FiguraGeometrica() //Metodo - Constructor de la clase...No retorna nada y si puede recibir parametros.
        {

        }
        //public float Area { get; set; } //prop tab tab...Atributo simple
        //private float area;//propfull tab tab
        //***Con este codigo se encapsula la variable area***
        public float Area //ATRIBUTO DE CALCULO
        {
            get { return Lado*Lado; }//obtener...Permite entregar obtener el valor de la variable privada
            //set { area = value; }//modificar...Establece el valor de la variable privada...Ya no va el set porque ya esta definido 
        }

        private float lado;//Variable encapsulada

        //ATRIBUTO DE MODIFICAR Y ACTUALIZAR
        public float Lado//Propiedad
        {
            get { return lado; }
            set {
                if (value<=0)
                {
                    throw new Exception("El dato del lado debe ser mayor de 0");//Para crear una exception
                }
                lado = value;

            }
        }


    }
}
