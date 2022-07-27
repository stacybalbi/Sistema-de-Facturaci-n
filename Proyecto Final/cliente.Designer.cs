namespace Proyecto_Final
{
    partial class cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.btnbuscarn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnbuscarc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(142, 250);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(152, 31);
            this.txtemail.TabIndex = 53;
            // 
            // txtelefono
            // 
            this.txtelefono.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtelefono.Location = new System.Drawing.Point(142, 203);
            this.txtelefono.Name = "txtelefono";
            this.txtelefono.Size = new System.Drawing.Size(152, 31);
            this.txtelefono.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 50;
            this.label7.Text = "Teléfono:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(410, 37);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(308, 31);
            this.txtbuscar.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "(Buscar por nombre y categoría)";
            // 
            // btnmostrar
            // 
            this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(183, 402);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(121, 39);
            this.btnmostrar.TabIndex = 46;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(44, 402);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(108, 39);
            this.btneliminar.TabIndex = 45;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(183, 342);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(121, 39);
            this.btnactualizar.TabIndex = 44;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(44, 342);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(108, 39);
            this.btninsertar.TabIndex = 43;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(142, 158);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(152, 31);
            this.txtnombre.TabIndex = 42;
            // 
            // txtcedula
            // 
            this.txtcedula.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula.Location = new System.Drawing.Point(142, 111);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(152, 31);
            this.txtcedula.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "RNC/Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Id:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(142, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(152, 31);
            this.txtid.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Datos del Cliente";
            // 
            // dgvcliente
            // 
            this.dgvcliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(340, 135);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(436, 306);
            this.dgvcliente.TabIndex = 35;
            this.dgvcliente.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 28);
            this.label8.TabIndex = 54;
            this.label8.Text = "Categoria:";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Items.AddRange(new object[] {
            "Premium",
            "Regular"});
            this.cmbcategoria.Location = new System.Drawing.Point(142, 294);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(152, 36);
            this.cmbcategoria.TabIndex = 55;
            // 
            // btnbuscarn
            // 
            this.btnbuscarn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarn.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarn.Location = new System.Drawing.Point(424, 74);
            this.btnbuscarn.Name = "btnbuscarn";
            this.btnbuscarn.Size = new System.Drawing.Size(131, 39);
            this.btnbuscarn.TabIndex = 56;
            this.btnbuscarn.Text = "Nombre";
            this.btnbuscarn.UseVisualStyleBackColor = true;
            this.btnbuscarn.Click += new System.EventHandler(this.btnbuscarn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final.Properties.Resources.Stacy_s_Camera_Shop;
            this.pictureBox2.Location = new System.Drawing.Point(360, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // btnbuscarc
            // 
            this.btnbuscarc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarc.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarc.Location = new System.Drawing.Point(571, 74);
            this.btnbuscarc.Name = "btnbuscarc";
            this.btnbuscarc.Size = new System.Drawing.Size(133, 39);
            this.btnbuscarc.TabIndex = 58;
            this.btnbuscarc.Text = "Categoria";
            this.btnbuscarc.UseVisualStyleBackColor = true;
            this.btnbuscarc.Click += new System.EventHandler(this.btnbuscarc_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscarc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnbuscarn);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcliente);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cliente";
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Button btnbuscarn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnbuscarc;
    }
}