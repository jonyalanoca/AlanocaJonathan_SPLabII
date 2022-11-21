using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializa
    {
        void SerializarJson(string nombre);
        void SerializarXml(string nombre);
    }
}
