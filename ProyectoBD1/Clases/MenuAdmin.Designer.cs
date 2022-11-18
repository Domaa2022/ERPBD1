namespace ProyectoBD1.Clases
{
    partial class MenuAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.radioArchivo = new System.Windows.Forms.RadioButton();
            this.radioPersonal = new System.Windows.Forms.RadioButton();
            this.radioInventario = new System.Windows.Forms.RadioButton();
            this.radioFacturacion = new System.Windows.Forms.RadioButton();
            this.radioClientes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Archivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(638, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Facturación";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(638, 235);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Clientes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // radioArchivo
            // 
            this.radioArchivo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioArchivo.AutoSize = true;
            this.radioArchivo.FlatAppearance.BorderSize = 0;
            this.radioArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.radioArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioArchivo.Location = new System.Drawing.Point(22, 3);
            this.radioArchivo.Name = "radioArchivo";
            this.radioArchivo.Size = new System.Drawing.Size(53, 23);
            this.radioArchivo.TabIndex = 0;
            this.radioArchivo.TabStop = true;
            this.radioArchivo.Text = "Archivo";
            this.radioArchivo.UseVisualStyleBackColor = true;
            this.radioArchivo.CheckedChanged += new System.EventHandler(this.radioArchivo_CheckedChanged);
            // 
            // radioPersonal
            // 
            this.radioPersonal.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPersonal.AutoSize = true;
            this.radioPersonal.FlatAppearance.BorderSize = 0;
            this.radioPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.radioPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPersonal.Location = new System.Drawing.Point(132, 3);
            this.radioPersonal.Name = "radioPersonal";
            this.radioPersonal.Size = new System.Drawing.Size(58, 23);
            this.radioPersonal.TabIndex = 1;
            this.radioPersonal.TabStop = true;
            this.radioPersonal.Text = "Personal";
            this.radioPersonal.UseVisualStyleBackColor = true;
            this.radioPersonal.CheckedChanged += new System.EventHandler(this.radioPersonal_CheckedChanged);
            // 
            // radioInventario
            // 
            this.radioInventario.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioInventario.AutoSize = true;
            this.radioInventario.FlatAppearance.BorderSize = 0;
            this.radioInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.radioInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioInventario.Location = new System.Drawing.Point(266, 3);
            this.radioInventario.Name = "radioInventario";
            this.radioInventario.Size = new System.Drawing.Size(64, 23);
            this.radioInventario.TabIndex = 2;
            this.radioInventario.TabStop = true;
            this.radioInventario.Text = "Inventario";
            this.radioInventario.UseVisualStyleBackColor = true;
            this.radioInventario.CheckedChanged += new System.EventHandler(this.radioInventario_CheckedChanged);
            // 
            // radioFacturacion
            // 
            this.radioFacturacion.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFacturacion.AutoSize = true;
            this.radioFacturacion.FlatAppearance.BorderSize = 0;
            this.radioFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.radioFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFacturacion.Location = new System.Drawing.Point(381, 3);
            this.radioFacturacion.Name = "radioFacturacion";
            this.radioFacturacion.Size = new System.Drawing.Size(73, 23);
            this.radioFacturacion.TabIndex = 3;
            this.radioFacturacion.TabStop = true;
            this.radioFacturacion.Text = "Facturación";
            this.radioFacturacion.UseVisualStyleBackColor = true;
            this.radioFacturacion.CheckedChanged += new System.EventHandler(this.radioFacturacion_CheckedChanged);
            // 
            // radioClientes
            // 
            this.radioClientes.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioClientes.AutoSize = true;
            this.radioClientes.FlatAppearance.BorderSize = 0;
            this.radioClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.radioClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioClientes.Location = new System.Drawing.Point(493, 2);
            this.radioClientes.Name = "radioClientes";
            this.radioClientes.Size = new System.Drawing.Size(54, 23);
            this.radioClientes.TabIndex = 4;
            this.radioClientes.TabStop = true;
            this.radioClientes.Text = "Clientes";
            this.radioClientes.UseVisualStyleBackColor = true;
            this.radioClientes.CheckedChanged += new System.EventHandler(this.radioClientes_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.radioClientes);
            this.panel1.Controls.Add(this.radioFacturacion);
            this.panel1.Controls.Add(this.radioInventario);
            this.panel1.Controls.Add(this.radioPersonal);
            this.panel1.Controls.Add(this.radioArchivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 31);
            this.panel1.TabIndex = 3;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RadioButton radioArchivo;
        private System.Windows.Forms.RadioButton radioPersonal;
        private System.Windows.Forms.RadioButton radioInventario;
        private System.Windows.Forms.RadioButton radioFacturacion;
        private System.Windows.Forms.RadioButton radioClientes;
        private System.Windows.Forms.Panel panel1;
    }
}