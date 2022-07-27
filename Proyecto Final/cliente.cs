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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }
        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");
        ccliente cc = new ccliente();
        private void cliente_Load(object sender, EventArgs e)
        {

        }
        //Insertar Clientes
        private void btninsertar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvcliente.Visible = true;
            cc.Insertar(txtcedula.Text,txtnombre.Text,txtelefono.Text, txtemail.Text, cmbcategoria.Text);

        }


        //Actualizar Datos
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvcliente.Visible = true;
            cc.actualizar(Convert.ToInt32(txtid.Text), txtcedula.Text, txtnombre.Text, txtelefono.Text, txtemail.Text, cmbcategoria.Text);
        }
        //Eliminar Datos
        private void btneliminar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvcliente.Visible = true;
            cc.Eliminar(Convert.ToInt32(txtid.Text));
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            dgvcliente.Visible = true;
            cc.Mostrar(dgvcliente);
        }

        //BuscarNombre
        private void btnbuscarn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM cliente WHERE nombre LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dgvcliente.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
        }
        //Buscar Categoria
        private void btnbuscarc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM cliente WHERE categoria LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dgvcliente.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
        }
    }
}
