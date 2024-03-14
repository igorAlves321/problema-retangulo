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
            Retangulo r = new Retangulo();
            Console.Write("digite a largura do retangulo:");
            r.largura = double.Parse(Console.ReadLine());
            Console.Write("digite a altura do retangulo:");
            r.altura = double.Parse(Console.ReadLine());

            double area = r.calcularArea();
            double p = r.calcularPerimetro();
            double d = r.calcularDiagonal();


            Console.WriteLine($"Área do retângulo: {area:F2}");
            Console.WriteLine($"Perímetro do retângulo: {p:F2}");
            Console.WriteLine($"Diagonal do retângulo: {d:F2}");
        }
    }
}
