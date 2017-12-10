namespace EEE
{
    partial class Login
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
            this.gruusuario = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbnusuario = new System.Windows.Forms.Label();
            this.lbncontra = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.gruusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gruusuario
            // 
            this.gruusuario.Controls.Add(this.txtcontrasena);
            this.gruusuario.Controls.Add(this.txtusuario);
            this.gruusuario.Controls.Add(this.lbncontra);
            this.gruusuario.Controls.Add(this.lbnusuario);
            this.gruusuario.Controls.Add(this.pictureBox2);
            this.gruusuario.Location = new System.Drawing.Point(12, 339);
            this.gruusuario.Name = "gruusuario";
            this.gruusuario.Size = new System.Drawing.Size(848, 231);
            this.gruusuario.TabIndex = 1;
            this.gruusuario.TabStop = false;
            this.gruusuario.Text = "Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EEE.Properties.Resources.login_icon_png_27;
            this.pictureBox2.Location = new System.Drawing.Point(17, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EEE.Properties.Resources._44460_625470184135716_731242211_n;
            this.pictureBox1.Location = new System.Drawing.Point(303, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbnusuario
            // 
            this.lbnusuario.AutoSize = true;
            this.lbnusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnusuario.Location = new System.Drawing.Point(414, 86);
            this.lbnusuario.Name = "lbnusuario";
            this.lbnusuario.Size = new System.Drawing.Size(102, 25);
            this.lbnusuario.TabIndex = 1;
            this.lbnusuario.Text = "USUARIO";
            // 
            // lbncontra
            // 
            this.lbncontra.AutoSize = true;
            this.lbncontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbncontra.Location = new System.Drawing.Point(364, 144);
            this.lbncontra.Name = "lbncontra";
            this.lbncontra.Size = new System.Drawing.Size(152, 25);
            this.lbncontra.TabIndex = 2;
            this.lbncontra.Text = "CONTRASEÑA";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(523, 86);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(228, 22);
            this.txtusuario.TabIndex = 3;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(523, 144);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(228, 22);
            this.txtcontrasena.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 598);
            this.Controls.Add(this.gruusuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.gruusuario.ResumeLayout(false);
            this.gruusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gruusuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lbncontra;
        private System.Windows.Forms.Label lbnusuario;
    }
}