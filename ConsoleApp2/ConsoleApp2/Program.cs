using System;
using FIGURAGEOMETRICA.Clase_encapsulado;

namespace FIGURAGEOMETRICA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FiguraGeometrica figuraGeometrica =
                new FiguraGeometrica(); //instacia
            figuraGeometrica.Lado = 5;
            //figuraGeometrica.Area = 4; No puede ser asignado
            Console.WriteLine(figuraGeometrica.Area);
            Console.Read();
        }
    }
}
