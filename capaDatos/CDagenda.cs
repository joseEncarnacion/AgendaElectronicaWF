using System.Configuration;
using System.Data;
using capaEntidad;
using System.Data.SqlClient;

namespace capaDatos
{
    public class CDagenda
    {

        SqlConnection conn =
          new SqlConnection(ConfigurationManager.ConnectionStrings["dataConnex"].ConnectionString);


        public DataTable Datos_Listar()
        {
            SqlCommand cmd = new SqlCommand("sp_listarPer", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Datos_insertarPersona(CEagencia arg)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarPersona", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", arg.nom);
            cmd.Parameters.AddWithValue("@apell", arg.Apellido);
            cmd.Parameters.AddWithValue("@nac", arg.nacimiento);
            cmd.Parameters.AddWithValue("@dir", arg.dir);
            cmd.Parameters.AddWithValue("@genero", arg.generoid);
            cmd.Parameters.AddWithValue("@ecivil", arg.estadoCivil);
            cmd.Parameters.AddWithValue("@movil", arg.movil);
            cmd.Parameters.AddWithValue("@tell", arg.tell);
            cmd.Parameters.AddWithValue("@correo", arg.correo);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void Datos_Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_elimiarpersona", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idPer", id);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void Datos_editarPersona(CEagencia arg)
        {
            SqlCommand cmd = new SqlCommand("sp_EditarPersona", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idper", arg.idPersona);
            cmd.Parameters.AddWithValue("@nom", arg.nom);
            cmd.Parameters.AddWithValue("@apell", arg.Apellido);
            cmd.Parameters.AddWithValue("@nac", arg.nacimiento);
            cmd.Parameters.AddWithValue("@dir", arg.dir);
            cmd.Parameters.AddWithValue("@genero", arg.generoid);
            cmd.Parameters.AddWithValue("@ecivil", arg.estadoCivil);
            cmd.Parameters.AddWithValue("@movil", arg.movil);
            cmd.Parameters.AddWithValue("@tell", arg.tell);
            cmd.Parameters.AddWithValue("@correo", arg.correo);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}