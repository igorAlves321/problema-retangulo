using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaRetangulo
{
    public class Retangulo
    {
         public double altura;
        public double largura;

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
            double d = Math.Sqrt(altura * altura + largura * largura)
                return d;
        }
    }
}
