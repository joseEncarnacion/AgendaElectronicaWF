using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace capaDatos
{
    public class CDusuario
    {

        SqlConnection conn =
         new SqlConnection(ConfigurationManager.ConnectionStrings["dataConnex"].ConnectionString);


        public DataTable Datos_Listar()
        {
            SqlCommand cmd = new SqlCommand("sp_usuario", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Datos_insertarPersona(CEUsuario US)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarusuario", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", US.UsuarioE);
            cmd.Parameters.AddWithValue("@pass", US.passE);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
