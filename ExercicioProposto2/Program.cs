using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, B, altura, perimetro, diagonal;

            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = B * altura; //formula para descobrir a area

            perimetro = 2 * B + 2 * altura; //formula para descobrir perimetro

            diagonal = Math.Sqrt(Math.Pow(B, 2) + Math.Pow(altura, 2)); //formula para descobrir diagonal (teorema de pitagoras)

            Console.WriteLine("Área: " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}