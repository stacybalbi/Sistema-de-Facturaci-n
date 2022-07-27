using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Final
{
    class cinventario : mantenimientop
    {
        //Se Utiliza la interfaz
        public void InsertarDatos()
        {
            MessageBox.Show("Datos Insertados Correctamente");

        }
        public void MostrarDatos()
        {
            MessageBox.Show("Datos Refrescados Correctamente");
        }
        public void EliminarDatos()
        {
            MessageBox.Show("DatoS Eliminados Correctamente");
        }
        public void ActualizarDatos()
        {
            MessageBox.Show("Datos Editados Correctamente");
        }

        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");

        
        public void Insertar(string nombre, int cantidad, string proveedor, MaskedTextBox fecha)
        {
            string query = "INSERT INTO entrada (nombre,cantidad,proveedor,fecha) VALUES (@nombre,@cantidad,@proveedor,@fecha)";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@proveedor", proveedor);
            comando.Parameters.AddWithValue("@fecha", fecha);

            comando.ExecuteNonQuery();
            InsertarDatos();
            Conectar.Close();
        }

        public void MostrarProducto(DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM producto", Conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            dgv.DataSource = tabla;
            MostrarDatos();

        }

        public void MostrarInventario(DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM entrada", Conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            dgv.DataSource = tabla;
            MostrarDatos();

        }

        
    }
}
