using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz:Utiles,ISerializa,IDeserializa
    {
        private ConsoleColor color;
        public Lapiz()
        {
        }
        public Lapiz(float precio):base(precio)
        { 
        }
        public Lapiz(float precio, string marca) : base(precio,marca)
        {

        }
        public Lapiz(float precio, string marca, ConsoleColor color) : this(precio, marca) {
            this.color = color;
        }

        public ConsoleColor Color { get => color; set => color = value; }

        public override string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Detalles());
            sb.AppendLine($"-Color: {this.color}");
            return sb.ToString();
        }

    }
}
