using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Comics_Gestion
{
    internal class ComicNegocio
    {
        public List<Comic> Listar()
        {
            List<Comic> lista = new List<Comic>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                conexion.ConnectionString = "SERVER vfd.=\\SQLEXPRESS; DATABASE=DISCOS_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text; 
                comando.CommandText = "select E.Descripcion Serie, D.Titulo, CantidadCanciones Volumen, UrlImagenTapa from estilos E, discos D";
                comando.Connection = conexion;

                conexion.Open();
                Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    Comic aux = new Comic();
                    aux.Serie = (string)Lector["Serie"];
                    aux.Titulo = (string)Lector["Titulo"];
                    aux.Volumen = (int)Lector["Volumen"];
                    aux.UrlImagen = (string)Lector["UrlImagenTapa"];
                }
                return lista;
            }
            catch (Exception e) 
            {
                throw e;
            } 
            finally 
            {
                conexion.Close();
            }

        }
    }
}
