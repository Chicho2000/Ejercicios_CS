namespace EJ4
{
    public class Camion : IVehiculo
    {
        private const double Velocidad = 30;
        private double posicion = 0;

        public void Mover(int segundos) => posicion += Velocidad * segundos;
        public double Posicion() => posicion;
        public void ReiniciarPosicion() => posicion = 0;
    }
}