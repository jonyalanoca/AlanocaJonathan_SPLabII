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
        private string material;
        public Sacapuntas(float precio) : base(precio)
        {
        }
        public Sacapuntas(float precio, string marca) : base(precio, marca)
        {

        }
        public Sacapuntas(float precio, string marca, string material):this(precio, marca)
        {
            this.material = material;
        }
        public override string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Detalles());
            sb.AppendLine($"-Material: {this.material}");
            return sb.ToString();
        }
    }
}
