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

            Retangulo r = new Retangulo(11.0, 5.0,"azul");
            Console.WriteLine("segundo retângulo. Área: " + r.calcularArea());
            Console.WriteLine("Perímetro: " + r.calcularPerimetro());
            Console.WriteLine("Diagonal: " + r.calcularDiagonal());
            Console.WriteLine("Cor: "+r.cor);
            Console.ReadKey();
        }
    }
}
