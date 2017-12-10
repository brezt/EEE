namespace EEE
{
    partial class Incio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.m = new System.Windows.Forms.TabControl();
            this.Consulta = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.m.SuspendLayout();
            this.Consulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // m
            // 
            this.m.Controls.Add(this.Consulta);
            this.m.Controls.Add(this.tabPage2);
            this.m.Controls.Add(this.tabPage1);
            this.m.Location = new System.Drawing.Point(1, 1);
            this.m.Name = "m";
            this.m.SelectedIndex = 0;
            this.m.Size = new System.Drawing.Size(1167, 547);
            this.m.TabIndex = 0;
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.btnEmpleado);
            this.Consulta.Location = new System.Drawing.Point(4, 25);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta.Size = new System.Drawing.Size(1159, 518);
            this.Consulta.TabIndex = 0;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1159, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1159, 518);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ayuda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(17, 339);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(229, 115);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "button1";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            // 
            // Incio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 547);
            this.Controls.Add(this.m);
            this.Name = "Incio";
            this.Text = "frminicio";
            this.m.ResumeLayout(false);
            this.Consulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl m;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

