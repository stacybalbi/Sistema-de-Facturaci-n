using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");
        cinventario ci = new cinventario();
        private void inventario_Load(object sender, EventArgs e)
        {
        
        }

        

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dgvproducto.Visible = true;
            pictureBox2.Visible = false;
            ci.MostrarInventario(dgvproducto);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Insertar();
            dgvproducto.Visible = true;
            pictureBox2.Visible = false;
            //ci.Insertar(txtnombre.Text,Convert.ToInt32(txtcantidad.Text), txtproveedor.Text, mtbfecha.Text);
        }

        public void Insertar()
        {
            string query = "INSERT INTO entrada (nombre,cantidad,proveedor,fecha) VALUES (@nombre,@cantidad,@proveedor,@fecha)";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            comando.Parameters.AddWithValue("@proveedor", txtproveedor.Text);
            comando.Parameters.AddWithValue("@fecha", txtfecha.Text);

            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado Correctamente");
            Conectar.Close();
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
     
     
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmostrarp_Click(object sender, EventArgs e)
        {
            dgvproducto.Visible = true;
            pictureBox2.Visible = false;
            ci.MostrarProducto(dgvproducto);
        }

        //Buscar Producto
        private void button1_Click(object sender, EventArgs e)
        {
            dgvproducto.Visible = true;
            pictureBox2.Visible = false;

            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM entrada WHERE nombre LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dgvproducto.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }


        }
        //Buscar Fecha
        private void button2_Click(object sender, EventArgs e)
        {
            dgvproducto.Visible = true;
            pictureBox2.Visible = false;

            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM entrada WHERE fecha LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dgvproducto.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }



        }
        //Buscar Proveedor
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvproducto.Visible = true;
            pictureBox2.Visible = false;

            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM entrada WHERE proveedor LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dgvproducto.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }


        }
    }
}
