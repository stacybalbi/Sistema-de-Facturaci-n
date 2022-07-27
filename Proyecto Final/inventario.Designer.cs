namespace Proyecto_Final
{
    partial class inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnmostrari = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnmostrarp = new System.Windows.Forms.Button();
            this.btnbuscarp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(367, 52);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(356, 31);
            this.txtbuscar.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(377, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "(Buscar por fecha, producto y proveedor)";
            // 
            // btnmostrari
            // 
            this.btnmostrari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrari.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmostrari.Location = new System.Drawing.Point(174, 406);
            this.btnmostrari.Name = "btnmostrari";
            this.btnmostrari.Size = new System.Drawing.Size(124, 74);
            this.btnmostrari.TabIndex = 69;
            this.btnmostrari.Text = "Mostrar Inventario";
            this.btnmostrari.UseVisualStyleBackColor = true;
            this.btnmostrari.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninsertar.Location = new System.Drawing.Point(103, 341);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(108, 39);
            this.btninsertar.TabIndex = 67;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtproveedor
            // 
            this.txtproveedor.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproveedor.Location = new System.Drawing.Point(73, 230);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(161, 31);
            this.txtproveedor.TabIndex = 66;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(73, 165);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(161, 31);
            this.txtcantidad.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(98, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 64;
            this.label4.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 28);
            this.label3.TabIndex = 63;
            this.label3.Text = "Cantidad de producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombre del producto:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(73, 100);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(161, 31);
            this.txtnombre.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 60;
            this.label1.Text = "Inventario";
            // 
            // dgvproducto
            // 
            this.dgvproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(317, 149);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(450, 331);
            this.dgvproducto.TabIndex = 59;
            this.dgvproducto.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbuscar.Location = new System.Drawing.Point(645, 98);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(122, 39);
            this.btnbuscar.TabIndex = 74;
            this.btnbuscar.Text = "Proveedor";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(116, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 75;
            this.label6.Text = "Fecha:";
            // 
            // btnmostrarp
            // 
            this.btnmostrarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrarp.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmostrarp.Location = new System.Drawing.Point(28, 406);
            this.btnmostrarp.Name = "btnmostrarp";
            this.btnmostrarp.Size = new System.Drawing.Size(124, 74);
            this.btnmostrarp.TabIndex = 77;
            this.btnmostrarp.Text = "Mostrar Productos";
            this.btnmostrarp.UseVisualStyleBackColor = true;
            this.btnmostrarp.Click += new System.EventHandler(this.btnmostrarp_Click);
            // 
            // btnbuscarp
            // 
            this.btnbuscarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarp.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbuscarp.Location = new System.Drawing.Point(495, 98);
            this.btnbuscarp.Name = "btnbuscarp";
            this.btnbuscarp.Size = new System.Drawing.Size(108, 39);
            this.btnbuscarp.TabIndex = 78;
            this.btnbuscarp.Text = "Producto";
            this.btnbuscarp.UseVisualStyleBackColor = true;
            this.btnbuscarp.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(349, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 39);
            this.button2.TabIndex = 79;
            this.button2.Text = "Fecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final.Properties.Resources.Stacy_s_Camera_Shop;
            this.pictureBox2.Location = new System.Drawing.Point(367, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 331);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(73, 295);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(161, 31);
            this.txtfecha.TabIndex = 83;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbuscarp);
            this.Controls.Add(this.btnmostrarp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnmostrari);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvproducto);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventario";
            this.Text = "inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnmostrari;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnmostrarp;
        private System.Windows.Forms.Button btnbuscarp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtfecha;
    }
}