using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerci__2
{
    internal class Program
    {
        static void Gestionarbiblioteca()

        {
            while (true)
            {

                Console.WriteLine("\nMenú de Gestión de biblioteca");

                Console.WriteLine("1. Agregar un libro");
                Console.WriteLine("2. Mostrar listado de libros");
                Console.WriteLine("3. Buscar libro por código");
                Console.WriteLine("4. Editar información de un libro");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Elija una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarLibro();
                        break;
                    case 2:
                        MostrarLibros();
                        break;
                    case 3:
                        BuscarLibroPorCodigo();
                        break;
                    case 4:
                        EditarLibro();
                        break;
                    case 5:

                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void AgregarLibro()
        {
            Console.Write("Ingrese el código del libro: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();

            Console.Write("Ingrese la edición del libro: ");
            int edicion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            Libro libro = new Libro(codigo, titulo, isbn, edicion, autor);

            biblioteca = Add(libro);

            Console.WriteLine("Libro agregado con éxito.");
        }

        static void MostrarLibros()
        {
            if (biblioteca.Count == 0)
            {
                Console.WriteLine("La biblioteca está vacía.");
            }
            else
            {
                Console.WriteLine("Listado de Libros:");
                Console.WriteLine("{0,-10} {1,-30} {2,-20} {3,-10} {4,-30}", "Código", "Título", "ISBN", "Edición", "Autor");
                foreach (var libro in biblioteca)
                {
                    Console.WriteLine($"{libro.Codigo,-10} {libro.Titulo,-30} {libro.ISBN,-20} {libro.Edicion,-10} {libro.Autor,-30}");
                }
            }
        }

        static void BuscarLibroPorCodigo()
        {
            Console.Write("Ingrese el código del libro a buscar: ");
            int codigo = int.Parse(Console.ReadLine());

            var libro = biblioteca.Find(l => l.Codigo == codigo);

            if (libro != null)
            {
                Console.WriteLine("Información del Libro:");
                Console.WriteLine($"Código: {libro.Codigo}");
                Console.WriteLine($"Título: {libro.Titulo}");
                Console.WriteLine($"ISBN: {libro.ISBN}");
                Console.WriteLine($"Edición: {libro.Edicion}");
                Console.WriteLine($"Autor: {libro.Autor}");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        static void EditarLibro()
        {
            Console.Write("Ingrese el código del libro a editar: ");
            int codigo = int.Parse(Console.ReadLine());

            var libro = biblioteca.Find(l => l.Codigo == codigo);

            if (libro != null)
            {
                Console.WriteLine("Información actual del Libro:");
                Console.WriteLine($"Código: {libro.Codigo}");
                Console.WriteLine($"Título: {libro.Titulo}");
                Console.WriteLine($"ISBN: {libro.ISBN}");
                Console.WriteLine($"Edición: {libro.Edicion}");
                Console.WriteLine($"Autor: {libro.Autor}");

                Console.WriteLine("\nIngrese la nueva información del libro:");

                Console.Write("Nuevo título: ");
                libro.Titulo = Console.ReadLine();

                Console.Write("Nuevo ISBN: ");
                libro.ISBN = Console.ReadLine();

                Console.Write("Nueva edición: ");
                libro.Edicion = int.Parse(Console.ReadLine());

                Console.Write("Nuevo autor: ");
                libro.Autor = Console.ReadLine();

                Console.WriteLine("Libro editado con éxito.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
    }

    class LlamadaTelefonica
    {
        public int Clave { get; set; }
        public string Zona { get; set; }
        public double PrecioPorMinuto { get; set; }
    }

    class Libro
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int Edicion { get; set; }
        public string Autor { get; set; }

        public Libro(int codigo, string titulo, string isbn, int edicion, string autor)
        {
            Codigo = codigo;
            Titulo = titulo;
            ISBN = isbn;
            Edicion = edicion;
            Autor = autor;
        }
    }



}

