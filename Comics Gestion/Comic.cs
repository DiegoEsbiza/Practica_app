using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comics_Gestion
{
    internal class Comic
    {
        public string Serie { get; set; }
        public string Titulo { get; set; }
        public int Volumen { get; set; }

        public string UrlImagen { get; set; }
    }
}
