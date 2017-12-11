using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEE
{
    public partial class Incio : Form
    {
        public Incio()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
             Form crear = new frmEmpleado();
            crear.Show();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            Form crear = new cargo();
            crear.Show();
        }

        private void btnnivel_Click(object sender, EventArgs e)
        {
            Form crear = new nivel_academico();
            crear.Show();
        }

        private void bntregistro_Click(object sender, EventArgs e)
        {
            Form crear = new Registro();
            crear.Show();
        }
    }
}
