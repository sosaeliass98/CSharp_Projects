using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor ingrese el año para buscar");
            string ingresoAño = Console.ReadLine();
            int año = 0;
            try
            {
                año = Convert.ToInt32(año);
            }
            catch
            {
                año = 0;
            }

            CatalogoPeliculas miCatalogo = new CatalogoPeliculas(año);

            var listaPeliculas = miCatalogo.ObtenerPorAño(año);

            Console.WriteLine("Listado de peliculas por año");
            foreach (var pelicula in listaPeliculas)
            {
                Console.WriteLine(pelicula);
            }

            MostrarPeliculas(listaPeliculas);

            var listaPeliculaGenero = miCatalogo.ObtenerPorAñoConsulta(año);
            MostrarPeliculas(listaPeliculaGenero);

            var listaPeliculasTitulo = miCatalogo.BuscarPorTitulo("Eso");
            MostrarPeliculas(listaPeliculasTitulo);

            

            Console.ReadKey();
        }

        static void MostrarPeliculas(IEnumerable<Pelicula> peliculas)
        {
            Console.WriteLine("Listado de peliculas por año");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula);
            }

            Console.ReadKey();
        }




    }
}
