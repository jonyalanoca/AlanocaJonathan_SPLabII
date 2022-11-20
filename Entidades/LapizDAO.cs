using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class LapizDAO
    {
        public static bool LeerLapiz(ref Cartuchera<Utiles> cartuchera)
        {
            bool todoOk = true;
            SqlConnection conSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "SELECT * FROM LAPICES";
            SqlCommand comando = new SqlCommand(consulta, conSql);
            comando.CommandType = System.Data.CommandType.Text;
            conSql.Open();
            SqlDataReader sr = comando.ExecuteReader();
            try
            {
                while (sr.Read())
                {
                    ConsoleColor auxColor;
                    Enum.TryParse<ConsoleColor>(sr["COLOR"].ToString(), out auxColor);
                    int auxId = (int)sr["ID_LAPIZ"];
                    float auxPrecio = float.Parse(sr["PRECIO"].ToString());
                    string auxMarca = sr["MARCA"].ToString();
                    Lapiz lapizAux = new Lapiz(auxId, auxPrecio, auxMarca, auxColor);
                    cartuchera.ListaUtiles.Add(lapizAux);

                }
            }
            catch (Exception ex)
            {
                todoOk = false;
            }
            finally
            {
                if (conSql.State == System.Data.ConnectionState.Open)
                {
                    conSql.Close();
                }
            }
            return todoOk;
        }
        public static bool AgregarLapiz(Lapiz lapiz)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "INSERT INTO LAPICES (PRECIO,MARCA,COLOR) VALUES (@precio, @marca, @color)";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@precio", lapiz.Precio.ToString());
            comando.Parameters.AddWithValue("@marca", lapiz.Marca);
            comando.Parameters.AddWithValue("@color", lapiz.Color.ToString());
            conexionSql.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return todoOK;
            }
            finally
            {
                conexionSql.Close();
            }
            return true;
        }

        public static bool ModificarLapiz(Lapiz lapiz)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "UPDATE LAPICES SET PRECIO=@precio,MARCA=@marca,COLOR=@color WHERE ID_LAPIZ= @id";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@id", lapiz.Id);
            comando.Parameters.AddWithValue("@precio", lapiz.Precio.ToString());
            comando.Parameters.AddWithValue("@marca", lapiz.Marca);
            comando.Parameters.AddWithValue("@color", lapiz.Color.ToString());
            conexionSql.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                todoOK = false;
            }
            finally
            {
                conexionSql.Close();
            }
            return true;
        }
        public static bool EliminarLapiz(Lapiz lapiz)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "DELETE FROM LAPICES WHERE ID_lAPIZ=@id";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@id", lapiz.Id);
            conexionSql.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                todoOK = false;
            }
            finally
            {
                conexionSql.Close();
            }
            return todoOK;
        }
    }
}
