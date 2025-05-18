using System;

namespace QuartoProjeto{
    class Program
    {
        static void Main(string[] args)
        {
            double area,b, B, h;

            b = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

            area = (b + B) / 2 * h;

            Console.WriteLine("O valor da área é: " +area);
        }
    }
}
