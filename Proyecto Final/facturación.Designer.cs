namespace Proyecto_Final
{
    partial class facturación
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnmostrarp = new System.Windows.Forms.Button();
            this.btnmostrari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(149, 69);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(161, 31);
            this.txtnombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cmbcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcategoria.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbcategoria.Items.AddRange(new object[] {
            "Premium",
            "Regular"});
            this.cmbcategoria.Location = new System.Drawing.Point(447, 66);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(152, 36);
            this.cmbcategoria.TabIndex = 57;
            this.cmbcategoria.SelectedIndexChanged += new System.EventHandler(this.cmbcategoria_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(330, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "Categoria:";
            // 
            // dvg
            // 
            this.dvg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dvg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Cursor = System.Windows.Forms.Cursors.No;
            this.dvg.Location = new System.Drawing.Point(12, 217);
            this.dvg.Name = "dvg";
            this.dvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg.Size = new System.Drawing.Size(373, 263);
            this.dvg.TabIndex = 58;
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(521, 192);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(161, 31);
            this.txtproducto.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(546, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 59;
            this.label1.Text = "Producto:";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(521, 372);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(161, 31);
            this.txtprecio.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(559, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "% ITBIS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(130, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 28);
            this.label5.TabIndex = 64;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(221, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 28);
            this.label6.TabIndex = 66;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 28);
            this.label7.TabIndex = 65;
            this.label7.Text = "Monto total a pagar:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(130, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 28);
            this.label9.TabIndex = 68;
            this.label9.Text = "0";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(17, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 28);
            this.label10.TabIndex = 67;
            this.label10.Text = "Sub-total:";
            // 
            // btninsertar
            // 
            this.btninsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninsertar.Location = new System.Drawing.Point(550, 430);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(108, 39);
            this.btninsertar.TabIndex = 69;
            this.btninsertar.Text = "Facturar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(521, 286);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(161, 31);
            this.txtcantidad.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(545, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 28);
            this.label11.TabIndex = 70;
            this.label11.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(308, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 40);
            this.label12.TabIndex = 72;
            this.label12.Text = "Facturación";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(15, 177);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(232, 31);
            this.txtbuscar.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(53, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 23);
            this.label13.TabIndex = 73;
            this.label13.Text = "(Buscar por Cliente)";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(253, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 76;
            this.button2.Text = "Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmostrarp
            // 
            this.btnmostrarp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmostrarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrarp.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmostrarp.Location = new System.Drawing.Point(473, 489);
            this.btnmostrarp.Name = "btnmostrarp";
            this.btnmostrarp.Size = new System.Drawing.Size(124, 74);
            this.btnmostrarp.TabIndex = 80;
            this.btnmostrarp.Text = "Mostrar Productos";
            this.btnmostrarp.UseVisualStyleBackColor = true;
            this.btnmostrarp.Click += new System.EventHandler(this.btnmostrarp_Click);
            // 
            // btnmostrari
            // 
            this.btnmostrari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmostrari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrari.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmostrari.Location = new System.Drawing.Point(619, 489);
            this.btnmostrari.Name = "btnmostrari";
            this.btnmostrari.Size = new System.Drawing.Size(124, 74);
            this.btnmostrari.TabIndex = 79;
            this.btnmostrari.Text = "Mostrar Facturas";
            this.btnmostrari.UseVisualStyleBackColor = true;
            this.btnmostrari.Click += new System.EventHandler(this.btnmostrari_Click);
            // 
            // facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(774, 605);
            this.Controls.Add(this.btnmostrarp);
            this.Controls.Add(this.btnmostrari);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "facturación";
            this.Text = "facturación";
            this.Load += new System.EventHandler(this.facturación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnmostrarp;
        private System.Windows.Forms.Button btnmostrari;
    }
}