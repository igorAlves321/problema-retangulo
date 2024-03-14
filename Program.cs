using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a largura do retângulo.");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("digite a altura do retangulo.");
            double altura = double.Parse(Console.ReadLine());
            double area = altura * largura;
            double p = 2 * (altura + largura);
            double d = Math.Sqrt(largura * largura + altura + altura);
            Console.WriteLine($"Área do retângulo: {area:F2}");
            Console.WriteLine($"Perímetro do retângulo: {p:F2}");
            Console.WriteLine($"Diagonal do retângulo: {d:F2}");
        }
    }
}
