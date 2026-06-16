namespace EJ4
{
	public class Bicicleta : IVehiculo
	{
		private const double Velocidad = 10;
		private double posicion = 0;

		public void Mover(int segundos) => posicion += Velocidad * segundos;
		public double Posicion() => posicion;
		public void ReiniciarPosicion() => posicion = 0;
	}
}