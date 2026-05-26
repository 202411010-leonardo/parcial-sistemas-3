using System;
using System.Collections.Generic;

namespace ExamenSistemas3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alumnos = new List<string> { "Leonardo", "Maria", "Carlos" };
            List<double> notas = new List<double> { 85.5, 92.0, 78.0 };

            Console.WriteLine("========================================");
            Console.WriteLine("     SISTEMA DE GESTIÓN DE NOTAS v1.0   ");
            Console.WriteLine("        SIS-III - Segundo Parcial       ");
            Console.WriteLine("========================================");
            Console.WriteLine("\n--- LISTA DE ESTUDIANTES REGISTRADOS ---");

            for (int i = 0; i < alumnos.Count; i++)
            {
                Console.WriteLine($"- Alumno: {alumnos[i].PadRight(10)} | Nota: {notas[i]} Pts.");
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("[ESTADO] Proyecto cargado correctamente.");
            Console.WriteLine("========================================");
        }
    }
}
