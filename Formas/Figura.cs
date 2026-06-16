using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Figura
    {
        private string _nombre = "";
        public Figura() { }
        public virtual double CalcularArea() { return 0; }

        public virtual double CalcularPerimetro() { return 0; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"{_nombre}: Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}");
        }
    }
}