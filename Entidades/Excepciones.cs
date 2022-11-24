using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraLlenaException:Exception
    {
        public CartucheraLlenaException() : base("La Cartuchera se encuntra Llena") { }
        public CartucheraLlenaException(string mensaje) : base(mensaje) { }
        public CartucheraLlenaException(string mensaje,Exception ex) : base(mensaje, ex) { }
    }
    public class SinCoincidenciasException : Exception
    {
        public SinCoincidenciasException() : base("No existe el Util con ese ID") { }
        public SinCoincidenciasException(string mensaje) : base(mensaje) { }
        public SinCoincidenciasException(string mensaje, Exception ex) : base(mensaje, ex) { }
    }
    public class SinTintaException : Exception
    {
        public SinTintaException() : base("El se agoto la tinta.") { }
        public SinTintaException(string mensaje) : base(mensaje) { }
        public SinTintaException(string mensaje, Exception ex) : base(mensaje, ex) { }
    }
}
