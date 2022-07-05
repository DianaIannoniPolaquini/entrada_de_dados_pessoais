using System;
using System.Globalization;

namespace ENTRADA_DE_DADOS
{
    internal class Program
    {
        static void Main(string[] args)

        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x;
            double y, altura;
            char ch;


            string s;

            string[] vet;
            string nome;
            string sexo;
            string idade;
            string altura2;

            Console.Write("Entre com um número inteiro: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Entre com uma altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Entre com um sexo (f/m): ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.Write("Entre com um nome, sexo (m/f), idade e altura: ");
            s = Console.ReadLine();
            
            string [] vet  = s.Split(' '); 
            nome = vet[0];
            sexo = vet[1];
            idade = vet[2];
            altura2 = vet[3];
            
            

            Console.WriteLine("RELATÓRIO FINAL: ");
            Console.WriteLine(x);
            Console.WriteLine(altura.ToString("F2", CI));
            Console.WriteLine(ch);
            Console.WriteLine(vet[0] + " / " + vet[1] + " / " + vet[2] + " / " + vet[3]);
        }
    }
}
