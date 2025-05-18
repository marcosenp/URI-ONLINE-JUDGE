using System;
using System.Globalization;

namespace SetimoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] s = Console.ReadLine().Split(' ');
            string ultimoNome = s[0];
            int idade = int.Parse(s[1]);
            double altura = double.Parse(s[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}