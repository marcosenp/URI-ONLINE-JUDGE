using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            string nome1 = s[0];
            double idade1 = double.Parse(s[1], CultureInfo.InvariantCulture);

            string[] x = Console.ReadLine().Split(' ');
            string nome2 = x[0];
            double idade2 = double.Parse(x[1], CultureInfo.InvariantCulture);

            double media = (idade1 + idade2) / 2;

            Console.WriteLine("A idade média de "+nome1+ " e " +nome2+ " é de "+media.ToString("F1"), CultureInfo.InvariantCulture+ " anos.");
        }
    }
}