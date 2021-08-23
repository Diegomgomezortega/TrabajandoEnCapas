using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class FormAdmProfes : Form
    {
        public FormAdmProfes()
        {
            InitializeComponent();
            dgvProfesionales.ColumnCount = 2;
            dgvProfesionales.Columns[0].HeaderText = "Código";
            dgvProfesionales.Columns[1].HeaderText = "Nombre";
            dgvProfesionales.Columns[0].Width = 60;
            dgvProfesionales.Columns[1].Width = 200;
        }
    }
}
