using System;

namespace ProblemaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(10.0, 5.0);
            Console.WriteLine("Área: " + retangulo.calcularArea());
            Console.WriteLine("Perímetro: " + retangulo.calcularPerimetro());
            Console.WriteLine("Diagonal: " + retangulo.calcularDiagonal());
            Console.ReadKey();
        }
    }
}
