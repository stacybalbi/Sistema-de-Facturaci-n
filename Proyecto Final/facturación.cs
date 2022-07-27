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
    public partial class facturación : Form
    {
        public facturación()
        {
            InitializeComponent();
        }

        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");

        cinventario ci = new cinventario();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void facturación_Load(object sender, EventArgs e)
        {
            cproducto cp = new cproducto();
            cp.Mostrar(dvg);
        }

        private void cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Buscar Cliente
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM facturacion WHERE cliente LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dvg.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            //Condicionales
            if (cmbcategoria.SelectedText == "Regular")
            {
                regular();
            }
            else
            {
                premiun();
            }


            //Insertando datos en tabla entrada
            string query = "INSERT INTO factura (nombre,cliente,cantidad,precio) VALUES (@nombre,@cliente,@cantidad,@precio)";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@nombre", txtproducto.Text);
            comando.Parameters.AddWithValue("@cliente", txtnombre.Text);
            comando.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            comando.Parameters.AddWithValue("@precio", txtprecio.Text);
            
            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado Correctamente");
            Conectar.Close();

            
            
        }


        void regular()
        {
            
            MessageBox.Show("No Aplica Descuento");
            int sub;
            label9.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            //label9.Text = cantidad * precio;
            sub = int.Parse(txtcantidad.Text) * int.Parse(txtprecio.Text);
            label9.Text = sub.ToString();

            double itbis;
            itbis = sub * 0.18 ;
            label5.Text = itbis.ToString();

            double total;
            total = sub + itbis;
            label6.Text = total.ToString();



        }

        void premiun()
        {
            MessageBox.Show("Descuento Aplicado");
            double sub;
            label9.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            sub = int.Parse(txtcantidad.Text) * int.Parse(txtprecio.Text) * 0.95;
            label9.Text = sub.ToString();

            double itbis;
            itbis = sub * 1.18;
            label5.Text = itbis.ToString();

            double total;
            total = sub + itbis;
            label6.Text = total.ToString();
        }

        private void datosfacturación()
        {
            string query = "INSERT INTO entrada (nombre,cantidad,precio) VALUES (@nombre,@cantidad,@precio)";
            Conectar.Open();
            SqlCommand comando = new SqlCommand(query, Conectar);
            comando.Parameters.AddWithValue("@nombre", txtproducto.Text);
            comando.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            comando.Parameters.AddWithValue("@precio", txtprecio.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado Correctamente");
            Conectar.Close();
        }
        //Buscar Fecha
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM facturacion WHERE fecha LIKE('%" + txtbuscar.Text.Trim() + "%') ";
                    ds = Utilidades.ejecutar(cmd);
                    dvg.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }


        }

        private void btnmostrarp_Click(object sender, EventArgs e)
        {
            ci.MostrarProducto(dvg);
        }

        private void btnmostrari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM factura", Conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            dvg.DataSource = tabla;
        }
    }
}
