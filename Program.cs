using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using System.Transactions;

namespace CalculoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            string cont = "S";

            while (cont == "S" || cont == "SIM")
            {

                Triangulo x, y;
                x = new Triangulo();
                y = new Triangulo();

                Console.WriteLine("Digite os valores do triangulo X:");
                x.A = double.Parse(Console.ReadLine());
                x.B = double.Parse(Console.ReadLine());
                x.C = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite os valores do triangulo Y:");
                y.A = double.Parse(Console.ReadLine());
                y.B = double.Parse(Console.ReadLine());
                y.C = double.Parse(Console.ReadLine());

                double areaX = x.Area();
                double areaY = y.Area();

                if (areaX > areaY)
                {
                    Console.WriteLine($"A area do triangulo X é maior ({areaX}). A area do trinagulo Y é igual a {areaY}");
                }
                else
                {
                    Console.WriteLine($"A area do triangulo Y é maior ({areaY}). A area do triangulo X é igual a {areaX}");

                }

                Console.WriteLine("Deseja realizar um novo calculo?(Sim/Não)");
                cont = Console.ReadLine().ToUpper();

            }
         

        }
    }
}
