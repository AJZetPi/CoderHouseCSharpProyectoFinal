using CoderHouse_CSharp_API.Model;
using CoderHouse_CSharp_API.Repository;
using System.Data.SqlClient;
using System.Data;

namespace CoderHouseCSharp.Repository
{
    public class ADO_Nombre
    {
        public static List<Usuario> DevolverNombrePorId(long id)
        {
            var listaUsuarios = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(General.connectionString()))
            {
                connection.Open();
                SqlCommand cmd6 = connection.CreateCommand();
                cmd6.CommandText = "SELECT Nombre FROM Usuario WHERE id = @id";
                var parametroid = new SqlParameter();
                parametroid.ParameterName = "id";
                parametroid.SqlDbType = SqlDbType.BigInt;
                parametroid.Value = id;


                cmd6.Parameters.Add(parametroid);
                cmd6.ExecuteNonQuery();
                var reader = cmd6.ExecuteReader();
                while (reader.Read())
                {
                    var usuario = new Usuario();
                    usuario.Nombre = reader.GetValue(0).ToString();
                    listaUsuarios.Add(usuario);
                }
                reader.Close();

                connection.Close();
            }
            return listaUsuarios;



        }
        public static List<Usuario> DevolverNombrePorNombreUsuario(string NombreUsuario)
        {
            var listaUsuarios = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(General.connectionString()))
            {
                connection.Open();
                SqlCommand cmd6 = connection.CreateCommand();
                cmd6.CommandText = "SELECT Nombre FROM Usuario WHERE NombreUsuario = @NombreUsuario";
                var parametroNombreUsuario = new SqlParameter();
                parametroNombreUsuario.ParameterName = "NombreUsuario";
                parametroNombreUsuario.SqlDbType = SqlDbType.VarChar;
                parametroNombreUsuario.Value = NombreUsuario;


                cmd6.Parameters.Add(parametroNombreUsuario);
                cmd6.ExecuteNonQuery();
                var reader = cmd6.ExecuteReader();
                while (reader.Read())
                {
                    var usuario = new Usuario();
                    usuario.Nombre = reader.GetValue(0).ToString();
                    listaUsuarios.Add(usuario);
                }
                reader.Close();

                connection.Close();
            }
            return listaUsuarios;



        }
    }
}
