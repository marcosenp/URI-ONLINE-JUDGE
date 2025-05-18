using System;
using System.Globalization;

namespace OitavoProjeto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Largura, Comprimento, ValorMetroQuadrado, ValorTerreno, area;

            Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ValorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Largura * Comprimento;

            ValorTerreno = area * ValorMetroQuadrado;

            Console.WriteLine("Valor da área: " +area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do terreno: " + ValorTerreno.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}