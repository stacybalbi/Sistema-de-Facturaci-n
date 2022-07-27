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
    
    public partial class Producto : Form
    {
       
        public Producto()
        {
            InitializeComponent();
        }
        //declaramos variables
        private int id;
        private string nombre;
        private int precio;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        //conexión
        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= progfinal ; Integrated Security = True");

        //Llamamos a la clase producto
        cproducto log = new cproducto();
        
        


        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Insertar Productos
        private void btninsertar_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = false;
            dgvproducto.Visible = true;

            if (txtnombre.Text == "" && txtprecio.Text == "")
            {
                MessageBox.Show("Inserte los datos correctamente correctamente");
            }
            else
            {
                log.Insertar(txtnombre.Text, Convert.ToInt32(txtprecio.Text));
            }
            

        }


        //Eliminar
        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = false;
            dgvproducto.Visible = true;

            if (txtid.Text =="" && txtnombre.Text == "" && txtprecio.Text == "")
            {
                MessageBox.Show("Inserte el ID correctamente");
            }
            else
            {
                log.Eliminar(Convert.ToInt32(txtid.Text));
            }
            
        }



        //Editar
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            dgvproducto.Visible = true;
            log.Mostrar(dgvproducto);
        }
        

        // Actualizar
        private void btnactualizar_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            dgvproducto.Visible = true;

            if (txtid.Text =="" && txtnombre.Text == "" && txtprecio.Text == "")
            {
                MessageBox.Show("Inserte todos los datos correctamente");
            }
            else
            {
                log.actualizar(Convert.ToInt32(txtid.Text), txtnombre.Text, Convert.ToInt32(txtprecio.Text)); log.actualizar(Convert.ToInt32(txtid.Text), txtnombre.Text, Convert.ToInt32(txtprecio.Text));
            }
            
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        

       

        
       

        private void btnbuscar_Click(object sender, EventArgs e)
        {
                    }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string cmd = "select * FROM producto WHERE Nombre LIKE('%" + txtbuscar.Text.Trim() + "%') ";
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
