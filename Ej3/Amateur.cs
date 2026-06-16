using System;

namespace Ej3
{
    public class Amateur : IJugador
    {
        private const int Limite = 20;
        private int minutosCorridos = 0;

        public bool Correr(int minutos)
        {
            if (Cansado())
            {
                Console.WriteLine("El amateur está cansado, no puede correr.");
                return false;
            }
            int disponible = Limite - minutosCorridos;
            if (minutos <= disponible)
            {
                minutosCorridos += minutos;
                return true;
            }
            minutosCorridos = Limite;
            return false;
        }

        public bool Cansado() => minutosCorridos >= Limite;

        public void Descansar(int minutos)
        {
            minutosCorridos = Math.Max(0, minutosCorridos - minutos);
        }
    }
}