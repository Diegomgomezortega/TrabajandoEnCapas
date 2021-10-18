using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            FormAdmDocentes form = new FormAdmDocentes();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            admAlumnos form = new admAlumnos();
            this.Hide();
            form.ShowDialog();
            this.Show();

        }
    }
}
