using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SacapuntasDAO
    {
        public bool LeerSPuntas(ref Cartuchera<Utiles> cartuchera)// corregir aca
        {
            bool todoOk = true;
            SqlConnection conSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "SELECT * FROM SACAPUNTAS";
            SqlCommand comando = new SqlCommand(consulta, conSql);
            comando.CommandType = System.Data.CommandType.Text;
            conSql.Open();
            SqlDataReader sr = comando.ExecuteReader();

            try
            {
                while (sr.Read())
                {
                    Materiales  auxMaterial;
                    Enum.TryParse<Materiales>(sr["MATERIAL"].ToString(), out auxMaterial);
                    int auxId = (int)sr["ID_SPUNTA"];
                    float auxPrecio = float.Parse(sr["PRECIO"].ToString());
                    string auxMarca = sr["MARCA"].ToString();
                    cartuchera.ListaUtiles.Add(new Sacapuntas(auxId, auxPrecio, auxMarca, auxMaterial));
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
        public bool AgregarSPunta(Sacapuntas sacapunta)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "INSERT INTO SACAPUNTAS (PRECIO,MARCA,MATERIAL) VALUES (@precio, @marca, @material)";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@precio", sacapunta.Precio);
            comando.Parameters.AddWithValue("@marca", sacapunta.Marca);
            comando.Parameters.AddWithValue("@material", sacapunta.Material.ToString());
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

        public bool ModificarSPunta(Sacapuntas sacapunta)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "UPDATE SACAPUNTAS SET PRECIO=@precio,MARCA=@marca,MATERIAL=@material WHERE ID_SPUNTA= @id";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@id", sacapunta.Id);
            comando.Parameters.AddWithValue("@precio", sacapunta.Precio.ToString());
            comando.Parameters.AddWithValue("@marca", sacapunta.Marca);
            comando.Parameters.AddWithValue("@material", sacapunta.Material.ToString());
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
        public bool EliminarSPunta(Sacapuntas sacapunta)
        {
            bool todoOK = true;
            SqlConnection conexionSql = new SqlConnection("Server=. ;DataBase=UTILES;Trusted_Connection=True");
            string consulta = "DELETE FROM SACAPUNTAS WHERE ID_SPUNTA=@id";
            SqlCommand comando = new SqlCommand(consulta, conexionSql);
            comando.Parameters.AddWithValue("@id", sacapunta.Id);
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
