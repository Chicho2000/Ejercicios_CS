using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Triangulo : Figura
    {
        private string _nombre = "Triángulo";
        private float baseTriangulo { get; set; }
        private float altura { get; set; }
        private float lado2 { get; set; }
        private float lado3 { get; set; }

        public Triangulo(float baseTriangulo, float altura, float lado2, float lado3)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return baseTriangulo + lado2 + lado3;
        }
    }
}