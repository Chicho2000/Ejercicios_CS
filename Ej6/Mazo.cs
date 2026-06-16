namespace EJ6
{
    public class Mazo
    {
        private List<Carta> cartas = new List<Carta>();
        private Random rng = new Random();

        private static readonly string[] Palos = { "Espadas", "Bastos", "Oros", "Copas" };
        private static readonly string[] Numeros = { "1", "2", "3", "4", "5", "6", "7", "Sota", "Caballo", "Rey" };

        public Mazo()
        {
            foreach (var palo in Palos)
                foreach (var numero in Numeros)
                    cartas.Add(new Carta(palo, numero));
        }

        public void Barajar()
        {
            for (int i = cartas.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (cartas[i], cartas[j]) = (cartas[j], cartas[i]);
            }
        }

        public Carta RobarCarta()
        {
            if (cartas.Count == 0)
            {
                Console.WriteLine("El mazo está vacío.");
                return null;
            }
            Carta carta = cartas[cartas.Count - 1];
            cartas.RemoveAt(cartas.Count - 1);
            return carta;
        }

        public int CuantasCartasQuedan() => cartas.Count;
    }
}