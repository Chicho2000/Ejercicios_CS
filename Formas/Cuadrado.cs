using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Cuadrado : Figura
    {
        private string _nombre = "Cuadrado";
        private float lado;
        public float Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Cuadrado(float lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return lado * lado;
        }
        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }
}