using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class ConeccionSQL
    {
        public SqlConnection GetConnection()
        {
            //profe cambiar la cadena de conexion segun su configuracion 
            SqlConnection cn = new SqlConnection("....");
            return cn;
        }
    }
}
