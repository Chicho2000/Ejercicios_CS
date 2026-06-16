namespace EJ4
{
	public interface IVehiculo
	{
		void Mover(int segundos);
		double Posicion();
		void ReiniciarPosicion();
	}
}