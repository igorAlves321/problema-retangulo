using System;

namespace ProblemaRetangulo
{
    public class Retangulo
    {
        public double altura;
        public double largura;
        public string cor;


        public Retangulo(double altura, double largura, string cor) : this(altura, largura)
        {
            this.cor = cor;
        }

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double calcularArea()
        {
            double area = altura * largura;
            return area;
        }

        public double calcularPerimetro()
        {
            double p = 2 * (altura + largura);
            return p;
        }

        public double calcularDiagonal()
        {
            double d = Math.Sqrt(altura * altura + largura * largura);
            return d;
        }
    }
}
