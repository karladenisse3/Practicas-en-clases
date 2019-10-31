
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista generica = Lista de conceptos similares
            List<int> lista = new List<int>();//son objetos. Cuando hayan <> pueden ir cualquier tipo de dato, es generico
            lista.Add(5);
            lista.Add(10);
            lista.Add(15);
            lista.Add(20);
            //lista.RemoveAt(10); Elimina la posicion
            //lista.Remove(10); Elimina el valor
            Console.WriteLine(lista.Contains(10));//Busca el valor y muestra si esta o no dentro 
            lista.Insert(2,12);//Inserta un valor ubicando primero la posicion y luego de la coma el valor
            //int suma = 0;
            foreach  (int item in lista)
            {
                //suma += item;
                Console.WriteLine(item);
            }
            //Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
