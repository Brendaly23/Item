using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir una tabla(clave de zona y costo por minuto)
            decimal[] precio = { 2.0m, 2.2m, 4.5m, 3.5m, 6.0m };


            Console.WriteLine("Costo de llamada por minuto");
            Console.WriteLine("Zona\tCosto por Minuto");
            for (int i = 0; i < precio.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t${precio[i]}");
            }
            Console.Write("Ingrese la clave de zona(1-6):");
                int claveZona = int.Parse(Console.ReadLine());
            if (claveZona >= 1 && claveZona <= 6)
            {
                Console.Write("Ingrese la cantidad de minuts utilizados: ");
                int minutos = int.Parse(Console.ReadLine());
                if (minutos >= 0)
                {
                    decimal costoTotal = precio[claveZona - 1] * minutos;
                    Console.WriteLine("\nResumen de la llamada: ");
                    Console.WriteLine("-----");
                    Console.WriteLine($"Clave de Zona:\t{claveZona}");
                    Console.WriteLine($"costo por minuto:\t${precio[claveZona - 1]}");
                    Console.WriteLine($"Minutos utilizados:\t{minutos}");
                    Console.WriteLine($"Costo Total:\t${costoTotal}");
                    Console.WriteLine("-----");


                }
                else
                {
                    Console.WriteLine("La cantidad de minutos debe de ser un numero positivo");

                }
            }
            else
            {
                Console.WriteLine("La clave de la Zona ingresada no es valida. Debe de estar entre 1 y 6");
            }
        }
    }
}
