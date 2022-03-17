using System;

/// <summary>
/// Guía :4
/// Ejercicio: 4
/// Fecha: 16 de Marzo de 2022
/// Autor:  Michel Rosales

/// </summary>


namespace Calificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string NombredelAlumno = null;

            //declaracion de variables 
            double Nota1, Nota2, Nota3, Nota4, NotaFinal;

            //Entrada de datos 


            Console.Title = "Ejercicio-4";
            Console.WriteLine("Ingrese el nombre del Alumno (a):");
            NombredelAlumno = Console.ReadLine();

            Console.WriteLine("La primera nota 1:");
            Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("La segunda nota 2:");
            Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("La tercera nota 3:");
            Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("La cuarto  nota 4:");
            Nota4 = double.Parse(Console.ReadLine());


            // Procesamiento de datos 
            NotaFinal = ((Nota1 + Nota2 + Nota3 + Nota4) / 4);

            // Salida de datos

            Console.WriteLine("La nota final del Alumno de la Materia de la Introduccion a la Informatica : {0} Tiene una nota final de  {1}", NombredelAlumno, NotaFinal);
            Console.ReadKey();
        }
    }
}
