using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Fibron:Utiles

    {
        public delegate void NotificarSinTinta(string mensaje, Fibron fb);
        public event NotificarSinTinta SinTintaEvento;
        private int nivelTinta;
        private int faltante;
        public int NivelTinta { get => nivelTinta; set => nivelTinta = value; }
        

        public Fibron()
        {

        }
        public Fibron(int id, float precio, string marca) : base(id, precio, marca)
        {
        }
        public Fibron(int id, float precio, string marca, int nvTinta):this(id, precio, marca){
            this.nivelTinta = nvTinta;
        }
        
        public void Resaltar(int cantidad)
        {
            try
            {
                if (nivelTinta - cantidad < 0)
                {
                    this.faltante = (nivelTinta - cantidad) * -1;
                    throw new SinTintaException();
                }
                else
                {
                    this.nivelTinta -= cantidad;
                }
                
            }catch(Exception ex)
            {
                this.SinTintaEvento.Invoke(ex.Message, this);
                
            }
        }
        public string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DETALLES DEL Fibron:");
            sb.Append(base.Detalles());
            sb.AppendLine($"-Nivel de tinta: {this.nivelTinta}");
            return sb.ToString();
        }
        public void Serialiar()
        {
            using (StreamWriter sw = new StreamWriter("FaltaTinta.log"))
            {

                sw.WriteLine($"falto {faltante}de tinta");
            }
        }

    }
}
