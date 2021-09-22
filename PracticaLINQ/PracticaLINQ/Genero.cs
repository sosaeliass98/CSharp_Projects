using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ
{
    public class Genero
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public Genero genero { get; set; }

        public int Año { get; set; }

        public string Director { get; set; }

        public bool Clasico { get; set; }
    }
}
