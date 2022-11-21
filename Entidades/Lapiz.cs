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
        private string ObtenerRuta
        {
            get
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return ruta;
            }
        }
        public override string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DETALLES DEL LAPIZ:");
            sb.Append(base.Detalles());
            sb.AppendLine($"-Color: {this.color}");
            return sb.ToString();
        }
        void ISerializa.SerializarJson(string nombre)
        {
            Serializador<Lapiz>.SerializarJason(this,$"{ObtenerRuta}\\{nombre}.txt");
        }
        void IDeserializa.SerializarJson(string nombre)
        {
            Lapiz auxLapiz=Serializador<Lapiz>.DeserializarJason(nombre);
            this.precio = auxLapiz.Precio;
            this.marca = auxLapiz.Marca;
            this.color = auxLapiz.Color;
            LapizDAO.ModificarLapiz(this);
        }
        void ISerializa.SerializarXml(string nombre)
        {
            Serializador<Lapiz>.SerializarXml(this, $"{ObtenerRuta}\\{nombre}.xml");
        }
        void IDeserializa.SerializarXml(string nombre)
        {
            Lapiz auxLapiz=Serializador<Lapiz>.DeserializarXml(nombre);
            this.precio = auxLapiz.Precio;
            this.marca = auxLapiz.Marca;
            this.color = auxLapiz.Color;
            LapizDAO.ModificarLapiz(this);
        }
    }
}
