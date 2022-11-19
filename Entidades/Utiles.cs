using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        protected float precio;
        protected string marca;
        protected Utiles()
        {

        }
        public Utiles(float precio)
        {
            this.precio = precio;
            this.marca = "generica";
        }
        public Utiles(float precio, string marca) : this(precio)
        {
            this.marca = marca;
        }
        public float Precio { get => this.precio; set => this.precio = value; }
        public string Marca { get => this.marca; set => this.marca = value; }
        public virtual string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Detalles del Util:");
            sb.AppendLine($"-Precio: {this.Precio}");
            sb.AppendLine($"-Marca: {this.Marca}");
            return sb.ToString();
        }
    }
}