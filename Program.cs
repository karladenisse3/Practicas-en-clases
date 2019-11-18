using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC_Vehiculo.Clases;

namespace TC_Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
                                 
            //Vehiculo vehiculo = new Vehiculo();
            Bus bus = new Bus("ABC-123","Mazda","2600",45,"Automatico");
            Camion camion = new Camion("ABS-521","Hyndai","3200",3,"Doble");
            Camion camion2 = new Camion("ABS-945", "Toyota", "3204", 3, "Normal");
            Vehiculo vehiculo;
            vehiculo = bus;//No da error por lo que un bus en un vehiculo
           // vehiculo = camion;
          

            /*Console.WriteLine(bus.Encender());
            Console.WriteLine(camion.Encender());*/
            //CONVERSION IMPLICITA--->Lo hace automaticamente, no es necesario declararlos
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Add(bus);
            //vehiculos.Add(camion2);
            //POLIMORFISMO
            /*vehiculos.Add(camion);
            vehiculos.Add(bus);
            vehiculos.Add(camion2);*/
            vehiculos.Add(new Bus("CDF-520","Chevrolet", "5201",35,"Automatico"));

            Console.WriteLine(bus.SubirPasajeros());

            foreach  (Vehiculo item in vehiculos)
            {

                Console.WriteLine((item as Bus).SubirPasajeros());

                Console.WriteLine(item.Encender());
                if (item is Bus )//Is para preguntar
                {
                    Console.WriteLine("Este es un bus " + (item as Bus).SubirPasajeros());
                   
                }
                if (item is Camion)
                {
                    Console.WriteLine("Es un camion ");
                    //(item as Bus).SubirPasajeros();//As para convertir
                }
            }

            //Console.WriteLine(bus.Encender());

            Console.ReadLine();
        }

    }
}
