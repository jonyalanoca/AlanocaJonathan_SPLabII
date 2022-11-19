using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T:Utiles
    {
        public delegate void NotificarLimePrecio(string mensaje);
        public event NotificarLimePrecio EventoPrecio;
        private List<T> listaUtiles;
        private int capacidad;
        public Cartuchera()
        {
            this.capacidad = 20;//ver si esto
            this.listaUtiles = new List<T>();
        }
        public List<T> ListaUtiles { get => this.listaUtiles; set => this.listaUtiles = value; }
        public float PrecioTotatCartuchera
        {
            
            get {
                float precioTotal = 0;
                foreach (T i in this.listaUtiles)
                {
                    precioTotal += i.Precio;
                }
                return precioTotal; 
            }
        }
        public static string operator +(Cartuchera<T> cartuchera, T util)
        {
            try
            {
                if (cartuchera.capacidad == cartuchera.listaUtiles.Count)
                {
                    throw new CartucheraLlenaException();
                }
                else if (cartuchera.PrecioTotatCartuchera + util.Precio > 500)
                {
                    cartuchera.EventoPrecio.Invoke("asd");
                }
                    cartuchera.listaUtiles.Add(util);
            }catch(Exception ex)
            {
                return ex.Message;
            }
            return "Se agrego el util a la cartuchera";
        }

    }

}
