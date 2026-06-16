using System;

namespace Ej3
{
    public class Profesional : IJugador
    {
        private const int Limite = 40;
        private int minutosCorridos = 0;

        public bool Correr(int minutos)
        {
            if (Cansado())
            {
                Console.WriteLine("El profesional está cansado, no puede correr.");
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