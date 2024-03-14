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
    }
}
