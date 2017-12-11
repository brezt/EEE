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
            this.label1 = new System.Windows.Forms.Label();
            this.bntregistro = new System.Windows.Forms.Button();
            this.btnnivel = new System.Windows.Forms.Button();
            this.btncargo = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.m.SuspendLayout();
            this.Consulta.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.m.Size = new System.Drawing.Size(913, 546);
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
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(905, 517);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(680, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 189);
            this.button1.TabIndex = 7;
            this.button1.Text = "REGISTRO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(455, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 189);
            this.button2.TabIndex = 6;
            this.button2.Text = "NIVEL ACADEMICO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(230, 164);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 189);
            this.button3.TabIndex = 5;
            this.button3.Text = "CARGO";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::EEE.Properties.Resources.icons8_user_144;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(5, 164);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 189);
            this.button4.TabIndex = 4;
            this.button4.Text = "EMPLEADO";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

