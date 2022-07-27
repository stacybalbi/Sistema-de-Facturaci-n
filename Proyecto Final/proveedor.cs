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
    public partial class proveedor : Form
    {
        public proveedor()
        {
            InitializeComponent();
        }


        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");
        cproveedor cp = new cproveedor();

        private void proveedor_Load(object sender, EventArgs e)
        {

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvproveedor.Visible = true;
            cp.Insertar(Convert.ToInt32(txtcedula.Text), txtnombre.Text, Convert.ToInt32(txtelefono.Text), txtemail.Text);
        }

        //Eliminar Datos
        private void btneliminar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvproveedor.Visible = true;
            cp.Eliminar(Convert.ToInt32(txtid.Text));
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvproveedor.Visible = true;
            cp.actualizar(Convert.ToInt32(txtid.Text), txtcedula.Text, txtnombre.Text, txtelefono.Text, txtemail.Text);
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvproveedor.Visible = true;
            cp.Mostrar(dgvproveedor);
        }

        //Buscar Por Nombre
        private void btnbuscarn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM proveedor WHERE nombre LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dgvproveedor.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }


        }

        //Buscar Por Gmail
        private void btnbuscare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM proveedor WHERE email LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dgvproveedor.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }


        }
    }
}
