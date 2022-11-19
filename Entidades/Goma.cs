using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma:Utiles
    {
        private List<string> listaAlcanceGoma;
        public Goma(float precio) : base(precio)
        {
            this.listaAlcanceGoma = new List<string>();
        }
        public Goma(float precio, string marca) :base(precio, marca)
        {
            this.listaAlcanceGoma = new List<string>();
        }
        public Goma(float precio, string marca, List<string> lGoma):this(precio, marca)
        {
            this.listaAlcanceGoma = lGoma;
        }

        public override string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Detalles());
            sb.Append($"-Material que borra:");
            foreach (string i in this.listaAlcanceGoma)
            {
                sb.Append($" {i}");
            }
            return sb.ToString();
        }
    }
}
