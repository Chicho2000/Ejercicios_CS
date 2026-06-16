namespace EJ4
{
	public class Carrera
	{
		private IVehiculo vehiculo1;
		private IVehiculo vehiculo2;

		public Carrera(IVehiculo v1, IVehiculo v2)
		{
			vehiculo1 = v1;
			vehiculo2 = v2;
		}

		public void Correr(int segundos)
		{
			vehiculo1.Mover(segundos);
			vehiculo2.Mover(segundos);

			Console.WriteLine($"Vehículo 1 llegó a: {vehiculo1.Posicion()} metros");
			Console.WriteLine($"Vehículo 2 llegó a: {vehiculo2.Posicion()} metros");

			if (vehiculo1.Posicion() > vehiculo2.Posicion())
				Console.WriteLine("¡Ganó el Vehículo 1!");
			else if (vehiculo2.Posicion() > vehiculo1.Posicion())
				Console.WriteLine("¡Ganó el Vehículo 2!");
			else
				Console.WriteLine("¡Empate!");
		}
	}
}