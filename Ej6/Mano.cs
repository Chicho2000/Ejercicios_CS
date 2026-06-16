namespace EJ6
{
    public class Mano
    {
        private List<Carta> cartas = new List<Carta>();

        public void RecibirCarta(Carta carta) => cartas.Add(carta);

        public void MostrarMano()
        {
            foreach (var carta in cartas)
                Console.WriteLine(carta);
        }

        public int CantidadDeCartas() => cartas.Count;
    }
}