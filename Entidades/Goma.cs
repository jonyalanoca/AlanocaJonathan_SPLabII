using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma:Utiles
    {
        private Tipos tipo;
        public Goma(int id, float precio, string marca) :base(id,precio, marca)
        {
            this.tipo = Tipos.SinDefinir;
        }
        public Goma(int id,float precio, string marca, Tipos tipo):this(id,precio, marca)
        {
            this.tipo = tipo;
        }

        public Tipos Tipo { get => this.tipo; set => this.tipo = value; }

        public override string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Detalles());
            sb.Append($"-Tipo de goma: {this.tipo}");
            return sb.ToString();
        }
    }
}
