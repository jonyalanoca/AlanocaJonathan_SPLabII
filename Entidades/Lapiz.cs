using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz:Utiles,ISerializa,IDeserializa
    {
        public Lapiz(float precio):base(precio)
        { 
        }
        public Lapiz(float precio, string marca) : base(precio,marca)
        {

        }

    }
}
