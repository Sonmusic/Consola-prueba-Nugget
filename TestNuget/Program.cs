using System;
using VectorsAndAngles;

namespace TestNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el eje x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el eje y");
            int y = int.Parse(Console.ReadLine());
            VectorsAndAngles.Vector vectora = new VectorsAndAngles.Vector(x, y);

            Console.WriteLine("Introduzca el eje x del vector b");
            int xb = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el eje y del vector b");
            int yb = int.Parse(Console.ReadLine());
            VectorsAndAngles.Vector vectorb = new VectorsAndAngles.Vector(xb, yb);

            Console.WriteLine($"Magnitud del vector a: {vectora.magnitude()}");
            Console.WriteLine($"Magnitud del vector b: {vectorb.magnitude()}");
            Console.WriteLine($"Producto punto: {vectora.DotProduct(vectorb)}");

            Console.WriteLine($"Angle between: {vectora.AngleBetween(vectorb)}");
        }
    }
}
