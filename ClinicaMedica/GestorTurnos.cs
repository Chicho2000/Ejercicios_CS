using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ClinicaMedica
{
    public class GestorTurnos
    {
        public Paciente RegistrarPaciente(
            ClinicaContext context,
            int dni)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine() ?? "";

            Console.Write("Telefono: ");
            string telefono = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            Console.Write("Fecha nacimiento: ");
            string fechaNacimiento = Console.ReadLine() ?? "";

            Paciente paciente = new Paciente(
                dni,
                nombre,
                apellido,
                telefono,
                email,
                fechaNacimiento);

            context.pacientes.Add(paciente);
            context.SaveChanges();

            return paciente;
        }

        public void MostrarTurnosPaciente(
            ClinicaContext context,
            int dni)
        {
            var turnos = context.turnos
                .Include(t => t.medico)
                .Include(t => t.especialidad)
                .Include(t => t.estado)
                .Where(t => t.dni == dni)
                .OrderBy(t => t.fecha)
                .ThenBy(t => t.hora)
                .ToList();

            if (!turnos.Any())
            {
                Console.WriteLine("No posee turnos.");
                return;
            }

            foreach (var turno in turnos)
            {
                Console.WriteLine(
                    $"{turno.fecha} {turno.hora} | " +
                    $"{turno.medico.nombre} {turno.medico.apellido} | " +
                    $"{turno.especialidad.nombre} | " +
                    $"{turno.estado.descripcion}");
            }
        }

        public void ReservarTurno(
            ClinicaContext context,
            int dni)
        {
            Console.WriteLine("Especialidades:");

            foreach (var e in context.especialidades)
            {
                Console.WriteLine($"{e.idEspecialidad} - {e.nombre}");
            }

            Console.Write("Id especialidad: ");

            int idEspecialidad =
                int.Parse(Console.ReadLine() ?? "0");

            var medicos = context.medicoEspecialidades
                .Where(me => me.idEspecialidad == idEspecialidad)
                .Select(me => me.medico)
                .ToList();

            Console.WriteLine("Medicos:");

            foreach (var medico in medicos)
            {
                Console.WriteLine(
                    $"{medico.matricula} - {medico.apellido} {medico.nombre}");
            }

            Console.Write("Matricula medico: ");

            int matricula =
                int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Fecha (AAAA-MM-DD): ");

            string fecha = Console.ReadLine() ?? "";

            Console.Write("Hora (HH:mm): ");

            string hora = Console.ReadLine() ?? "";

            bool ocupado = context.turnos.Any(t =>
                t.matricula == matricula &&
                t.fecha == fecha &&
                t.hora == hora &&
                t.estado.descripcion != "cancelado");

            if (ocupado)
            {
                Console.WriteLine(
                    "El medico ya tiene un turno en ese horario.");
                return;
            }

            bool repetido = context.turnos.Any(t =>
                t.dni == dni &&
                t.matricula == matricula &&
                t.fecha == fecha &&
                t.estado.descripcion != "cancelado");

            if (repetido)
            {
                Console.WriteLine(
                    "Ya posee un turno con ese medico ese dia.");
                return;
            }

            Turno nuevoTurno = new Turno(
                context,
                dni,
                matricula,
                idEspecialidad,
                fecha,
                hora);

            context.turnos.Add(nuevoTurno);

            context.SaveChanges();

            Console.WriteLine("Turno reservado.");
        }

        public void CancelarTurno(
            ClinicaContext context,
            int dni)
        {
            var turnos = context.turnos
                .Include(t => t.estado)
                .Where(t =>
                    t.dni == dni &&
                    t.estado.descripcion != "cancelado")
                .ToList();

            if (!turnos.Any())
            {
                Console.WriteLine(
                    "No posee turnos para cancelar.");
                return;
            }

            Console.WriteLine("Turnos:");

            foreach (var turno in turnos)
            {
                Console.WriteLine(
                    $"{turno.fecha} {turno.hora}");
            }

            Console.Write("Fecha: ");
            string fecha = Console.ReadLine() ?? "";

            Console.Write("Hora: ");
            string hora = Console.ReadLine() ?? "";

            Turno? turnoCancelar =
                turnos.FirstOrDefault(t =>
                    t.fecha == fecha &&
                    t.hora == hora);

            if (turnoCancelar == null)
            {
                Console.WriteLine(
                    "Turno no encontrado.");
                return;
            }

            turnoCancelar.cancelarTurno(context);

            Console.WriteLine(
                "Turno cancelado correctamente.");
        }
    }
}