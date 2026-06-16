namespace Formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> formas = new List<Figura>();
            formas.Add(new Rectangulo(7, 3));
            formas.Add(new Cuadrado(4));
            formas.Add(new Rectangulo(6, 4));
            formas.Add(new Triangulo(5, 4, 4, 4));

            foreach (Figura forma in formas)
            {
                forma.MostrarInformacion();
            }

        }
    }
}