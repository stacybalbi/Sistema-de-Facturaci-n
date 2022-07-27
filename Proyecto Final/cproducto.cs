using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Final
{
    class cproducto : mantenimientop    
    {

        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");


        //Uso de la Interfaz
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


        public void Insertar(string nombre, int precio)
        {
            string query = "INSERT INTO producto (nombre,precio) VALUES (@nombre,@precio)";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            InsertarDatos();
            Conectar.Close();
        }

        public void Eliminar(int id)
        {
            string query = "DELETE FROM producto WHERE id = @id";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Conectar.Close();
            EliminarDatos();
        }

        public void Mostrar(DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM producto", Conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            dgv.DataSource = tabla;
            MostrarDatos();

        }

        public void actualizar(int id, string nombre,int precio)
        {
            string query = "UPDATE producto SET nombre = @nombre , precio = @precio WHERE id = @id";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            Conectar.Close();
            ActualizarDatos();
        }

       
    }
}
