using System;

namespace ClinicaMedica
{
    public class Paciente
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string? telefono { get; set; }
        public string? email { get; set; }
        public string fechaNacimiento { get; set; }

        public Paciente()
        {
        }

        public Paciente(
            int dni,
            string nombre,
            string apellido,
            string? telefono,
            string? email,
            string fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void mostrarDatos()
        {
            Console.WriteLine(
                $"Datos Paciente: {nombre} {apellido} {telefono} {fechaNacimiento} {email}");
        }
    }
}