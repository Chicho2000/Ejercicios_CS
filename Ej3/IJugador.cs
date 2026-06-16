using System;

namespace Ej3
{
    public interface IJugador
    {
        bool Correr(int minutos);
        bool Cansado();
        void Descansar(int minutos);
    }
}