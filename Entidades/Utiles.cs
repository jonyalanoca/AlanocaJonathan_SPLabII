namespace Entidades
{
    public abstract class Utiles
    {
        protected float precio;
        protected string marca;
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
       
    }
}