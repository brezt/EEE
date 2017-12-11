namespace EEE
{
    partial class pension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pension));
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesde = new System.Windows.Forms.TextBox();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidpension = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "TIEMPO MINIMO";
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(132, 91);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(100, 22);
            this.txtdesde.TabIndex = 26;
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(403, 91);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(100, 22);
            this.txthasta.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "TIEMPO MAXIMO";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(498, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(51, 17);
            this.lblusuario.TabIndex = 30;
            this.lblusuario.Text = "ADMIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Usuario";
            // 
            // txtidpension
            // 
            this.txtidpension.Location = new System.Drawing.Point(132, 63);
            this.txtidpension.Name = "txtidpension";
            this.txtidpension.Size = new System.Drawing.Size(51, 22);
            this.txtidpension.TabIndex = 31;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(403, 177);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(122, 48);
            this.btneliminar.TabIndex = 25;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(274, 177);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(123, 48);
            this.btnimprimir.TabIndex = 24;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(145, 177);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(123, 48);
            this.btnguardar.TabIndex = 23;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncrear
            // 
            this.btncrear.Image = ((System.Drawing.Image)(resources.GetObject("btncrear.Image")));
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(27, 177);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(112, 48);
            this.btncrear.TabIndex = 22;
            this.btncrear.Text = "Crear";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrear.UseVisualStyleBackColor = true;
            // 
            // pension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 314);
            this.Controls.Add(this.txtidpension);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.label1);
            this.Name = "pension";
            this.Text = "pension";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdesde;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidpension;
    }
}