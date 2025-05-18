using System;
using System.Globalization;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 12.123;

            Console.WriteLine(x);

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}