using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TransformadorTiempo
    {
        private static int horas;
        private static int minutos;
        private static int segundos;
        static TransformadorTiempo()
        {
            TransformadorTiempo.horas = 0;
            TransformadorTiempo.minutos = 0;
            TransformadorTiempo.segundos = 0;
        }
        /// <summary>
        /// recibe los segundos y los transfomar en minutos y horas segun corresponda 
        /// </summary>
        /// <param name="segundos"></param>
        /// <returns> retorna un string del formato de tiempo inicado</returns>
        public static string Transformar(int segundos)
        {
            StringBuilder sb = new StringBuilder();
            TransformadorTiempo.horas = (segundos / 3600);
            TransformadorTiempo.minutos = ((segundos - horas * 3600) / 60);
            TransformadorTiempo.segundos = segundos % 60;
            sb.Append($"{TransformadorTiempo.horas}:{TransformadorTiempo.minutos}:{TransformadorTiempo.segundos}");
            return sb.ToString();
        }
    }
}
