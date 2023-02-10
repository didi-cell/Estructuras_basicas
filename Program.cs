using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Ejercicio4._4._4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos estudiantes quieres calificar?");
            int nEstudiantes = int.Parse(Console.ReadLine());
            Alumnos[] a = new Alumnos[nEstudiantes];

            for (int i = 0; i <= a.Length; i++)
            {
               
                Console.WriteLine("Escribe el nombre del alumno: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Escribe la Nota 1: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la Nota 2: ");
                double nota2 = double.Parse(Console.ReadLine());
                //Console.ReadLine();
                //double promedio=a[i].getPromedio();
                a[i] = new Alumnos(nombre, nota1, nota2);
            }
            for (int i = 0; i <=a.Length; i++)
            {
                Console.WriteLine("NOMBRE: " + a[i].getNombre() + "\n NOTA 1: " + a[i].getNota1() + "\n NOTA 2: " + a[i].getNota2() + "\n" + "PROMEDIO: " + a[i].setPromedio);

                //Console.WriteLine("PROMEDIO: " + promedio.ToString("0.00"));

                Console.WriteLine("SUMA TOTAL ES : " + (a[i].getPromedio() + a[i].getPromedio()) + "MEDIA ARITMÉTICA: " + a[i].getPromedio() / nEstudiantes);
            }
                Console.WriteLine("Pulse una tecla: ");
                Console.ReadKey();
            
            
        }
    }
}

