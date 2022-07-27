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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        
        //Conexión a la base de datos
        SqlConnection Conectar = new SqlConnection("Data Source= DESKTOP-ENRFLS6;  Initial Catalog= finalprog ; Integrated Security = True");
        void conex()
        {
            try
            {
                Conectar.Open();
                Console.WriteLine("Conexion establecida");
            }
            catch
            {
                Console.WriteLine("No se pudo");
            }
            Conectar.Close();
        }
        void logins()
        {

            try
            {
                Conectar.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT usuario, contraseña from inicio where usuario='" + txtuser.Text + "' AND contraseña='" + txtpass.Text + "' ", Conectar))
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Te logeaste correctamente");

                        prog b = new prog();
                        b.Show();
                        
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Intenta de nuevo");
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            conex();
            logins();
        }

       
    }
   

}
