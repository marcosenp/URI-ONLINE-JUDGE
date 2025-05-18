using System;

namespace QuintoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, x, y, z;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            string[] s = Console.ReadLine().Split(' '); // ou: string[] vet = s.Split(' ');
 
            string a = s[0]; // ou: string a = vet[0];
            string b = s[1]; // ou: string b = vet[1];
            string c = s[2]; // ou: string c = vet[2];

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine("Você digitou: " + x);
            Console.WriteLine("Você digitou: " + y);
            Console.WriteLine("Você digitou: " + z);
            Console.WriteLine("Você digitou: " + a+ " " + b + " " + c);
           
        }
    }
}