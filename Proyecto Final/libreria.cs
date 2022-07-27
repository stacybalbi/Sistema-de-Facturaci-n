using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Final
{
    public abstract class Utilidades
    {
        public static DataSet ejecutar(string cmd)
        {
            SqlConnection connect = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");
            connect.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd, connect);

            adaptador.Fill(DS);

            connect.Close();

            return DS;
        }

        

        
    }

}
