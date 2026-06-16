using Microsoft.Data.Sqlite;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ClinicaMedica
{
    class Program
    {
        static void Main(string[] args)
        {

            ClinicaContext context = new ClinicaContext();
            GestorTurnos gestor = new GestorTurnos();

            Console.WriteLine("=== CLINICA MEDICA ===");
            Console.Write("Ingrese DNI: ");

            int dni = int.Parse(Console.ReadLine() ?? "0");

            Paciente? paciente = context.pacientes
                .FirstOrDefault(p => p.dni == dni);

            if (paciente == null)
            {
                Console.WriteLine("Paciente no encontrado.");
                Console.WriteLine("Procediendo al registro...");

                paciente = gestor.RegistrarPaciente(context, dni);
            }

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Ver mis turnos");
                Console.WriteLine("2 - Reservar turno");
                Console.WriteLine("3 - Cancelar turno");
                Console.WriteLine("4 - Mostrar mis datos");
                Console.WriteLine("5 - Salir");

                Console.Write("Opcion: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        gestor.MostrarTurnosPaciente(context, paciente.dni);
                        break;

                    case "2":
                        gestor.ReservarTurno(context, paciente.dni);
                        break;

                    case "3":
                        gestor.CancelarTurno(context, paciente.dni);
                        break;

                    case "4":
                        paciente.mostrarDatos();
                        break;

                    case "5":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }
    }
}