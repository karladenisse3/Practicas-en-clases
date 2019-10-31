using System;


namespace LISTA_ARREGLO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EL ARREGLO ES ESTATICO, ES UN OBJETO QUE PUEDE IMPLEMENTAR INTERFACES 
            TODO ARREGLO ES UN OBJETO*/
            int[] arreglo = new int [5];//instanciar arreglo...Se utiliza cuando se sabe el maximo y el tope.
            arreglo[0] = 10;
            arreglo[1] = 15;
            arreglo[2] = 20;
            arreglo[3] = 25;
            arreglo[4] = 30;

            //ICOLLECTION
            int suma = 0;
            foreach (int item in arreglo)
            /*similar al FOR pero mas facil. 
              El item va ha ir recorriendo cada uno de los valores. solo se utiliza con listas y arreglos.*/
            {
                suma += item;
            }

            Console.WriteLine(suma);

            Console.Read();
        }
    }
}
