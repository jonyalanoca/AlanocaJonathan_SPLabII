using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapuntas:Utiles
    {
        private Materiales material;

        public Sacapuntas(int id, float precio, string marca) : base(id, precio, marca)
        {
            this.material = Materiales.SinDefinir;
        }
        public Sacapuntas(int id, float precio, string marca, Materiales material):this(id,precio, marca)
        {
            this.material = material;
        }

        public Materiales Material { get => material; set => material = value; }

        public override string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Detalles());
            sb.AppendLine($"-Material: {this.material}");
            return sb.ToString();
        }
    }
}
