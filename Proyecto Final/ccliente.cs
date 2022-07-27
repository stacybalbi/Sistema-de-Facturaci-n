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
    class ccliente : mantenimientop
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




        public void Insertar(string rnc, string nombre, string telefono, string email, string categoria)
        {
            string query = "INSERT INTO cliente (rnc,nombre,telefono,email,categoria) VALUES (@rnc,@nombre,@telefono,@email,@categoria)";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@rnc", rnc);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@categoria", categoria);
            
            comando.ExecuteNonQuery();
            InsertarDatos();
            Conectar.Close();
        }



        public void Eliminar(int id)
        {
            string query = "DELETE FROM cliente WHERE id = @id";
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM cliente", Conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            dgv.DataSource = tabla;
            MostrarDatos();

        }

        public void actualizar(int id, string rnc, string nombre, string telefono, string email, string categoria)
        {
            string query = "UPDATE cliente SET nombre = @nombre , rnc = @rnc, telefono = @telefono, email = @email, categoria = @categoria WHERE id = @id";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@rnc", rnc);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            Conectar.Close();
            ActualizarDatos();
        }
    }
}
