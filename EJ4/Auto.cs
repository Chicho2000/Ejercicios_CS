namespace EJ4
{
    public class Auto : IVehiculo
    {
        private double velocidad;
        private double posicion = 0;

        public Auto(double velocidad = 40)
        {
            this.velocidad = velocidad;
        }

        public void Mover(int segundos) => posicion += velocidad * segundos;
        public double Posicion() => posicion;
        public void ReiniciarPosicion() => posicion = 0;
    }
}