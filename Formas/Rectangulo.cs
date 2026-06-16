using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Rectangulo : Figura
    {
        private string _nombre = "Rectángulo";
        private float baseRectangulo { get; set; }
        private float alturaRectangulo { get; set; }

        public Rectangulo(float baseRectangulo, float alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }
        public override double CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + alturaRectangulo);
        }
    }
}