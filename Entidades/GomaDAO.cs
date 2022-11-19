using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Xml;

namespace Entidades
{
    public class GomaDAO
    {
        public bool LeerGoma(ref Cartuchera<Utiles> cartuchera)// corregir aca
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
                    cartuchera.ListaUtiles.Add(new Goma(auxId, auxPrecio, auxMarca, auxTipo));
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
        public bool AgregarGoma(Goma goma)
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
        
        public bool ModificarGoma(Goma goma)
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
        public bool EliminarGoma(Goma goma)
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
    }
}
