using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ
{
    public class Pelicula
    {
        public int ID { get; set; }

        public string Titulo { get; set; }

        public Genero Genero { get; set; }

        public int Año { get; set; }

        public string Director { get; set; }

        public bool Clasico { get; set; }

        public override string ToString()
        {
            return $"Titulo {Titulo} Año {Año}";
        }
    }
}
