﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes

            Console.WriteLine("");
            var q = details.Select(emp => new { emp.Nombre, emp.Apellido });
            Console.WriteLine(string.Join("\n", q));

            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine(" ");
            var multiz = details.OrderByDescending(prome => prome.Promedio).Select(x => new { x.Nombre, x.Apellido });
            Console.WriteLine(string.Join(" \n", multiz));

            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("");
            var multiz1 = details.OrderBy(prome => prome.Apellido).Select(x => new { x.Apellido });
            Console.WriteLine(string.Join(" \n", multiz1));

            //4. Muestre por pantalla los datos del estudiante mas joven
            var edad1 = details.OrderBy(x => x).First();
            Console.WriteLine(string.Join("\n", edad1.Nombre));

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            //2. Muestre por pantalla los números pares
            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
        }
    }
}
