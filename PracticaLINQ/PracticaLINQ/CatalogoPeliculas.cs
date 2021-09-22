using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ
{
    class CatalogoPeliculas
    {
        public List<Pelicula> Peliculas { get; private set; }
        public int ID { get; private set; }

        public CatalogoPeliculas(int año)
        {
            Peliculas = new List<Pelicula>();
            InicializarListaPeliculas();
        }

        private void InicializarListaPeliculas()
        {
            Genero terror = new Genero()
            {
                ID = 1,
                    Nombre = "Terror"
            };
            Genero comedia = new Genero()
            {
                ID = 2,
                    Nombre = "Comedia"
            };
            Genero policial = new Genero()
            {
                ID = 3,
                    Nombre = "Policial"
            };
            Genero cienciaFiccion = new Genero()
            {
                ID = 4,
                    Nombre = "Ciencia Ficcion"
            };

            Peliculas.Add(new Pelicula()
            {
                ID=1,
                    Titulo="Eso",
                    Año=2012,
                    Director="Thomas Perez",
                    Clasico=false,
                    Genero=terror
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 1,
                Titulo = "Rapido y Furioso",
                Año = 2021,
                Director = "Guillermo Ortiz",
                Clasico = false,
                Genero = terror
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 1,
                Titulo = "Nacho Libre",
                Año = 2008,
                Director = "Pedro de la Vega",
                Clasico = false,
                Genero = comedia
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 1,
                Titulo = "Avengers: END GAME",
                Año = 2019,
                Director = "Angel Romero",
                Clasico = false,
                Genero = cienciaFiccion
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 2,
                Titulo = "Mi Vecino Es Un Espia",
                Año = 2007,
                Director = "Jackie Chan",
                Clasico = false,
                Genero = comedia
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 2,
                Titulo = "Capitan America: Civil War",
                Año = 2017,
                Director = "Jack Russo",
                Clasico = false,
                Genero = cienciaFiccion
            });
            Peliculas.Add(new Pelicula()
            {
                ID =3,
                Titulo = "Locos Por Mary",
                Año = 2005,
                Director = "Adam Sandler",
                Clasico = false,
                Genero = comedia
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 4,
                Titulo = "Zoolander",
                Año = 2006,
                Director = "Jack Nicholson",
                Clasico = false,
                Genero = comedia
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 3,
                Titulo = "Remuneracion",
                Año = 2012,
                Director = "Thomas Perez",
                Clasico = false,
                Genero = cienciaFiccion
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 4,
                Titulo = "Inception",
                Año = 2010,
                Director = "Thomas Perez",
                Clasico = false,
                Genero = cienciaFiccion
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 1,
                Titulo = "Eso",
                Año = 2012,
                Director = "Thomas Perez",
                Clasico = false,
                Genero = terror
            });
            Peliculas.Add(new Pelicula()
            {
                ID = 9,
                Titulo = "Avatar",
                Año = 2010,
                Director = "Batman",
                Clasico = false,
                Genero = null
            });

        }

        public IEnumerable<Pelicula> ObtenerPorAño(int año)
        {
            return Peliculas.Where(peli => peli.Año == año).OrderBy(peli => peli.Titulo);
        }

        public IEnumerable<Pelicula> ObtenerPorAñoConsulta(int año)
        {
            return from p in Peliculas
                   where p.Año == año
                   orderby p.Titulo
                   select p;
        }

        public IEnumerable<Pelicula> ObtenerPorGenero(int genero)
        {
            return Peliculas
                .Where(peli => peli.Genero?.ID == genero)
                .OrderBy(peli => peli.Titulo);
        }

        public IEnumerable<Pelicula> BuscarPorTitulo(string busqueda)
        {
            return Peliculas
                .Where(peli => peli.Titulo.Contains(busqueda.ToUpper()))
                .OrderBy(peli => peli.Titulo);
        }

        public void MostrarTodasLasPeliculas()
        {
            var resultado = from p in Peliculas
                   orderby p.Titulo
                   select new { p.Titulo, p.Año };

            foreach (var item in resultado)
            {
                Console.WriteLine($"Titulo:  { item.Titulo}, Año: { item.Año}");
            }
        }

        public void MostrarTodasLasPeliculasConClasePeliculaResumen()
        {
            var resultado = from p in Peliculas
                            orderby p.Titulo
                            select new PeliculaResumen(){ Titulo= p.Titulo, Año = p.Año };

            foreach (var item in resultado)
            {
                Console.WriteLine($"Titulo:  { item.Titulo}, Año: { item.Año}");
            }
        }
    }
}
