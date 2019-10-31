using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaClase.Clases;

namespace ListaClase
{
    class Program
    {
        static void Main(string[] args)
        {//Definido como variable
            Producto arroz = new Producto()
            {
                Codigo = 5,
                Descripcion = "Arroz flor",
                Precio = 3
            };//El constructor es un metodo por eso los () pero este es otro metodo 

            Producto azucar = new Producto()
            {
                Codigo = 1,
                Descripcion = "Azucar",
                Precio = 2
            };

            //no esta definido como variable
            List<Producto> listaDeProductos = new List<Producto>()
            {
                arroz, azucar,
                new Producto(){
                    Codigo = 2,
                    Descripcion = "Jabon",
                    Precio = 2
                }
            };

            listaDeProductos.Add(new Producto()
            {
                Codigo = 6,
                Descripcion = "Cafe   ",
                Precio = 1
            });

            double suma = 0;
            //listaDeProductos.RemoveAt(1);
            Console.WriteLine(listaDeProductos.Contains(arroz));
            listaDeProductos.Remove(new Producto() { Codigo=6,Descripcion="Cafe",Precio=1});//los objetos nunca van hacer igual...van a tener un modificador interno que los hace distinto
            foreach (Producto item in listaDeProductos)
            {
                //Console.WriteLine(item.Codigo+ " " + item.Descripcion+ " " + item.Precio);
                Console.WriteLine(item.ToString());
                suma += item.Precio;
                
            }

            Console.WriteLine("Suma: "+suma);
            Console.ReadKey();


        }
    }
}
