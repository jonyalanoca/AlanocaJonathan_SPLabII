using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz:Utiles,ISerializa,IDeserializa
    {
        private ConsoleColor color;
        public Lapiz()//probar luego si podemos ponerlo en privado (para serializar o deserealizar)
        {
        }
        public Lapiz(int id, float precio, string marca) : base(id, precio,marca)
        {
            this.color = ConsoleColor.Black;
        }
        public Lapiz(int id, float precio, string marca, ConsoleColor color) : this(id,precio, marca) {
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
        public void CompletarTabla( )
        {
           
        }

    }
}
