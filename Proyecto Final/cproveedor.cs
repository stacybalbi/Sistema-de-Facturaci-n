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
    class cproveedor : mantenimientop
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


        //private Conexion conex = new Conexion();


        public void Insertar(int rnc, string nombre, int telefono, string email)
        {
            string query = "INSERT INTO proveedor (rnc,nombre,telefono,email) VALUES (@rnc,@nombre,@telefono,@email)";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@rnc", rnc);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            

            comando.ExecuteNonQuery();
            InsertarDatos();
            Conectar.Close();
        }



        public void Eliminar(int id)
        {
            string query = "DELETE FROM proveedor WHERE id = @id";
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM proveedor", Conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            dgv.DataSource = tabla;
            MostrarDatos();

        }

        public void actualizar(int id, string rnc, string nombre, string telefono, string email)
        {
            string query = "UPDATE proveedor SET nombre = @nombre , rnc = @rnc, telefono = @telefono, email = @email WHERE id = @id";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@rnc", rnc);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
            Conectar.Close();
            MessageBox.Show("Actualizado Correctamente");
            ActualizarDatos();
        }
       
       

       
    }
}
