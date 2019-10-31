using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClase.Clases
{
    public class Producto //Heredada de la clase OBJECT
    {
        //CREAR METODO...Devuelve el codigo y la descripcion del producto
        public string mostrarProducto()
        {
            return Codigo.ToString() +" "+ Descripcion;
        }
        //

        //HERENCIA
        public override string ToString()
        {
            return Codigo.ToString() + " " + Descripcion + " " + Precio.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }



    }
}
