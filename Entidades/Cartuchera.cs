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
            this.capacidad = 10;//Limite maximo de la cartuchera
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

        public int Capacidad { get => capacidad; set => capacidad = value; }

        public static string operator +(Cartuchera<T> cartuchera, T util)
        {
            try
            {
                if (cartuchera.capacidad <= cartuchera.listaUtiles.Count)
                {
                    throw new CartucheraLlenaException();
                }
                else if (cartuchera.PrecioTotatCartuchera + util.Precio > 500)
                {
                    cartuchera.EventoPrecio.Invoke(cartuchera.InfoCartuchera());
                }
                cartuchera.listaUtiles.Add(util);
            }catch(Exception ex)
            {
                return ex.Message;
            }
            return "Se agrego el util a la cartuchera";
        }
        public static string  operator-(Cartuchera<T> cartuchera, T util)
        {
            if (cartuchera.ListaUtiles.Remove(util))
            {
                return "Se borro el registro";
            }
            return "No se encontro el util\nNo hubo cambios";
        }
        public Utiles BuscarUtilPorId(int id)
        {
            foreach(var i in listaUtiles)
            {
                if (id == i.Id)
                {
                    return i;
                }
            }
            throw new SinCoincidenciasException("No se encontro ningun ");
        }
        private string InfoCartuchera()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Informe Cartuchar del {DateTime.Now}");
            foreach (var i in listaUtiles)
            {
                sb.AppendLine(i.Detalles());
            }
            sb.AppendLine("----------------------------------------------------------------");
            return sb.ToString();

        }

    }

}
