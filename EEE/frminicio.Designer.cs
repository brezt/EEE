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
            this.bntregistro = new System.Windows.Forms.Button();
            this.btnnivel = new System.Windows.Forms.Button();
            this.btncargo = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
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
            this.m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m.Name = "m";
            this.m.SelectedIndex = 0;
            this.m.Size = new System.Drawing.Size(1167, 546);
            this.m.TabIndex = 0;
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.label1);
            this.Consulta.Controls.Add(this.bntregistro);
            this.Consulta.Controls.Add(this.btnnivel);
            this.Consulta.Controls.Add(this.btncargo);
            this.Consulta.Controls.Add(this.btnEmpleado);
            this.Consulta.Location = new System.Drawing.Point(4, 25);
            this.Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consulta.Size = new System.Drawing.Size(1159, 517);
            this.Consulta.TabIndex = 0;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // bntregistro
            // 
            this.bntregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntregistro.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.bntregistro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntregistro.Location = new System.Drawing.Point(682, 320);
            this.bntregistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntregistro.Name = "bntregistro";
            this.bntregistro.Size = new System.Drawing.Size(219, 189);
            this.bntregistro.TabIndex = 3;
            this.bntregistro.Text = "REGISTRO";
            this.bntregistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntregistro.UseVisualStyleBackColor = true;
            this.bntregistro.Click += new System.EventHandler(this.bntregistro_Click);
            // 
            // btnnivel
            // 
            this.btnnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnivel.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.btnnivel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnivel.Location = new System.Drawing.Point(457, 320);
            this.btnnivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnivel.Name = "btnnivel";
            this.btnnivel.Size = new System.Drawing.Size(219, 189);
            this.btnnivel.TabIndex = 2;
            this.btnnivel.Text = "NIVEL ACADEMICO";
            this.btnnivel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnivel.UseVisualStyleBackColor = true;
            this.btnnivel.Click += new System.EventHandler(this.btnnivel_Click);
            // 
            // btncargo
            // 
            this.btncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargo.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.btncargo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncargo.Location = new System.Drawing.Point(232, 320);
            this.btncargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncargo.Name = "btncargo";
            this.btncargo.Size = new System.Drawing.Size(219, 189);
            this.btncargo.TabIndex = 1;
            this.btncargo.Text = "CARGO";
            this.btncargo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncargo.UseVisualStyleBackColor = true;
            this.btncargo.Click += new System.EventHandler(this.btncargo_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleado.Location = new System.Drawing.Point(7, 320);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(219, 189);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "EMPLEADO";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1159, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1159, 517);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ayuda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni Bd BT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(302, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSULTA ";
            // 
            // Incio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 546);
            this.Controls.Add(this.m);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Incio";
            this.Text = "frminicio";
            this.m.ResumeLayout(false);
            this.Consulta.ResumeLayout(false);
            this.Consulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl m;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bntregistro;
        private System.Windows.Forms.Button btnnivel;
        private System.Windows.Forms.Button btncargo;
        private System.Windows.Forms.Label label1;
    }
}

