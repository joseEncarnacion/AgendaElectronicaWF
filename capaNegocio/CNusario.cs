using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using capaDatos;

namespace capaNegocio
{
    public class CNusario
    {

        CDusuario usuario = new CDusuario();


        public void NE_crearUusario(CEUsuario user)
        {
            usuario.Datos_insertarPersona(user);

        }

        public DataTable NEBuscarUsuario()
        {
            return usuario.Datos_Listar();
        }



    }
}
