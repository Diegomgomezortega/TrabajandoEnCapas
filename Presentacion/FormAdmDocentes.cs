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
    public partial class FormAdmDocentes : Form
    {
        public FormAdmDocentes()
        {
            InitializeComponent();
            dgvpersonas.ColumnCount = 2;
            dgvpersonas.Columns[0].HeaderText = "Código";
            dgvpersonas.Columns[1].HeaderText = "Nombre";
            dgvpersonas.Columns[0].Width = 60;
            dgvpersonas.Columns[1].Width = 200;
            LlenarDGV();
        }
        public Docente objEntDoc = new Docente();//Instancia de Docente, es un objeto
        public NegProfesionales objNegDoc = new NegProfesionales();//Instancia de negocios Profesionales, es un objeto
        private void LlenarDGV()

        {
            dgvpersonas.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = objNegDoc.listadoDocentes("Todos");//Data set devuelve una lista, en este caso de docentes cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    dgvpersonas.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else lblInformacion.Text = "No hay personas cargadas en el sistema";
        }
        private void Txtbox_a_obj()//metodo para tomar los datos del formulario y colocar los atributos a la instacia de la clase, Toma los datos de ls txbox y utiliza las propiedades de la clase docente
        {
            objEntDoc.CodProf = Convert.ToInt32(txtCodigo.Text);
            objEntDoc.Nombre = txtNombre.Text;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int ngrabados = -1;//la utilizo para detectar si fue grabado exitosamente o no
            Txtbox_a_obj();
            ngrabados = objNegDoc.abmDocentes("Alta", objEntDoc);//
            if (ngrabados == -1)
            {
                lblInformacion.Text = "No se pudo grabar los datos en el sistema";
            }
            else
            {
                lblInformacion.Text = "Se grabaron los datos con éxito";
                LlenarDGV();
                Limpiar();//Limpia los textBox
            }
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void dgvpersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntDoc.CodProf = Convert.ToInt32(dgvpersonas.CurrentRow.Cells[0].Value);
            ds = objNegDoc.listadoDocentes(objEntDoc.CodProf.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btnGrabar.Visible = false;
                lblInformacion.Text = string.Empty;
            }
         }//Para modificar los datos haciendo click en la celda del dgv
        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtCodigo.Enabled = false;
        }

        private void btnModficar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            Txtbox_a_obj();
            nResultado = objNegDoc.abmDocentes("Modificar", objEntDoc);//Invoco a la capa de negocios
            if (nResultado != -1)
            {
                lblInformacion.Text = "Los datos fueron modificados con éxito";
                Limpiar();
                LlenarDGV();
                txtCodigo.Enabled = true;
            }
            else
            {
                lblInformacion.Text = ("Se produjo un error al intentar modificar los datos");
            }
         }
        
    }
    
}
