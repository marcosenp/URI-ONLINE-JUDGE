using System;
using System.Globalization;

namespace SextoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            char ch;
            double n2;
            string nome;
            char sexo;
            int idade;
            double altura;

            n1 = int.Parse(Console.ReadLine());
            ch = char.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string[] s = Console.ReadLine().Split(' ');
            nome = s[0];
            sexo = char.Parse(s[1]);
            idade = int.Parse(s[2]);    
            altura = double.Parse(s[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: " + n1);
            Console.WriteLine("Você digitou: " + ch);
            Console.WriteLine("Você digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Você digitou: " + nome);
            Console.WriteLine("Você digitou: " + sexo);
            Console.WriteLine("Você digitou: " + idade);
            Console.WriteLine("Você digitou: " + altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}