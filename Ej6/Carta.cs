namespace EJ6
{
    public class Carta
    {
        public string Palo { get; }
        public string Numero { get; }

        public Carta(string palo, string numero)
        {
            Palo = palo;
            Numero = numero;
        }

        public override string ToString() => $"{Numero} de {Palo}";
    }
}