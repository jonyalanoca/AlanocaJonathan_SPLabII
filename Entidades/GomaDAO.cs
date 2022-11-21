using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Xml;
using System.Diagnostics;

namespace Entidades
{
    public static class GomaDAO
    {
        public static bool LeerGoma(ref Cartuchera<Utiles> cartuchera)
        {
            bool todoOk = true;
            SqlConnection conSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "SELECT * FROM GOMAS";
            SqlCommand comando = new SqlCommand(consulta,conSql);
            comando.CommandType = System.Data.CommandType.Text;
            conSql.Open();
            SqlDataReader sr = comando.ExecuteReader();

            try
            {
                while (sr.Read())
                {
                    Tipos auxTipo;
                    Enum.TryParse<Tipos>(sr["TIPO"].ToString(), out auxTipo);
                    int auxId = (int)sr["ID_GOMA"];
                    float auxPrecio = float.Parse(sr["PRECIO"].ToString());
                    string auxMarca = sr["MARCA"].ToString();
                    Goma auxGoma = new Goma(auxId, auxPrecio, auxMarca, auxTipo);
                    cartuchera.ListaUtiles.Add(auxGoma);
                }
            }
            catch (Exception ex)
            {
                todoOk= false;
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
        public static bool AgregarGoma(Goma goma)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "INSERT INTO GOMAS (PRECIO,MARCA,TIPO) VALUES (@precio, @marca, @tipo)";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@precio", goma.Precio.ToString());
            comando.Parameters.AddWithValue("@marca", goma.Marca);
            comando.Parameters.AddWithValue("@tipo", goma.Tipo.ToString());
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
        
        public static bool ModificarGoma(Goma goma)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "UPDATE GOMAS SET PRECIO=@precio,MARCA=@marca,TIPO=@tipo WHERE ID_GOMA= @id";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@id", goma.Id.ToString());
            comando.Parameters.AddWithValue("@precio", goma.Precio.ToString());
            comando.Parameters.AddWithValue("@marca", goma.Marca);
            comando.Parameters.AddWithValue("@tipo", goma.Tipo.ToString());
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
        public static bool EliminarGoma(Goma goma)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "DELETE FROM GOMAS WHERE ID_GOMA=@id";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@id", goma.Id.ToString());
            conexionSql.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                todoOK= false;
            }
            finally
            {
                conexionSql.Close();
            }
            return todoOK;
        }
        public static int UltimoId()
        {
            int id = -1;
            SqlConnection conSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "SELECT MAX(ID_GOMA) FROM GOMAS";
            SqlCommand comando = new SqlCommand(consulta, conSql);
            comando.CommandType = System.Data.CommandType.Text;
            conSql.Open();
            SqlDataReader sr = comando.ExecuteReader();

            try
            {
                sr.Read();
                id=int.Parse(sr[0].ToString());
            }
            catch(Exception ex)
            {
                id = 1000;
            }
            finally
            {
                if (conSql.State == System.Data.ConnectionState.Open)
                {
                    conSql.Close();
                }
            }
            return id;
        }
        public static int SumarUnoPorID(this Lapiz variable)
        {
            return (3+1);
        }
    }
}
