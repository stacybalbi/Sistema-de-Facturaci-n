using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Final
{
    public partial class prog : Form
    {
        public prog()
        {
            InitializeComponent();
        }
        //Interface para el login
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        // Para abrir los demas formularios en el panel
        private void abrirformhija(object formhija)
        {
            if (this.panelcentral.Controls.Count > 0)
                this.panelcentral.Controls.RemoveAt(0);
            Form fh =  formhija as Form;
            fh.TopLevel = false;
            this.panelcentral.Controls.Add(fh);
            this.panelcentral.Tag = fh;
            fh.Show();

        }

        //Botones del formulario
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        //Paneles del formulario
        private void menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Botones del Menu
        private void btnproducto_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            abrirformhija(new Producto());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            abrirformhija(new proveedor());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            abrirformhija(new cliente());
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            abrirformhija(new inventario());
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            abrirformhija(new facturación());
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            abrirformhija(new reportes());
        }
    }
}
