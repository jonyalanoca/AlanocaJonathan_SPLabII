using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        protected int id;
        protected float precio;
        protected string marca;
        protected Utiles()
        {

        }
        public Utiles(int id, float precio, string marca):this()
        {
            this.id = id;
            this.precio = precio;
            this.marca = marca;
        }
        public int Id { get => this.id; set => this.id = value; }
        public float Precio { get => this.precio; set => this.precio = value; }
        public string Marca { get => this.marca; set => this.marca = value; }
        public virtual string Detalles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-ID: {this.id}");
            sb.AppendLine($"-Precio: {this.Precio}");
            sb.AppendLine($"-Marca: {this.Marca}");
            return sb.ToString();
        }
    }
}