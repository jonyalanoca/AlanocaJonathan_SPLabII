using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Serializador<T> where T:class
    {
        public static void SerializarJason(T objeto, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonSerializer.Serialize(objeto));
            }
        }
        public static T DeserializarJason(string path)
        {
            T objeto;
            using (StreamReader sr = new StreamReader(path))
            {
                objeto = JsonSerializer.Deserialize<T>(sr.ReadLine());
            }
            return objeto;
        }
        public static void SerializarXml(T objeto, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                serializador.Serialize(sw, objeto);
            }
        }
        public static T DeserializarXml(string path)
        {
            T objeto;
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                objeto = (T)serializador.Deserialize(sr);
            }
            return objeto;
        }
        
    }
}
