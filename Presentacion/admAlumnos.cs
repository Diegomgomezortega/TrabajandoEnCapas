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
    public partial class admAlumnos : Form
    {
        public admAlumnos()
        {
            InitializeComponent();
            dgvpersonas.ColumnCount = 7;
            dgvpersonas.Columns[0].HeaderText = "DNI";
            dgvpersonas.Columns[1].HeaderText = "NOMBRE";
            dgvpersonas.Columns[2].HeaderText = "APELLIDO";
            dgvpersonas.Columns[3].HeaderText = "CARRERA";
            dgvpersonas.Columns[4].HeaderText = "GENERO";
            dgvpersonas.Columns[5].HeaderText = "FECHA NACIMIENTO";
            dgvpersonas.Columns[6].HeaderText = "LEGAJO";
            dgvpersonas.Columns[0].Width = 100;
            dgvpersonas.Columns[1].Width = 200;
            dgvpersonas.Columns[2].Width = 200;
            dgvpersonas.Columns[3].Width = 100;
            dgvpersonas.Columns[4].Width = 200;
            dgvpersonas.Columns[5].Width = 100;
            dgvpersonas.Columns[6].Width = 200;
            LlenarDGV();
            string[] Carreras= new string[9];
            Carreras[0] = "Administración y Gestión Publica";
            Carreras[1] = "Desarrollo de Software";
            Carreras[2] = "Enfermería";
            Carreras[3] = "Gestión ambiental";
            Carreras[4] = "Gestion y Administracion de las Organizaciones";
            Carreras[5] = "Gestion y Mantenimiento Industrial";
            Carreras[6] = "Optica y Contactologia";
            Carreras[7] = "Protesis Dental";
            Carreras[8] = "Seguridad e Higiene Laboral";
            btnBorrar.Visible = false;
            btnModficar.Visible = false;
            cbxCarrera.DataSource = Carreras;
        }
        
        bool confirmar;
        public Alumno entAlum = new Alumno();
        public NegProfesionales objNegAlum = new NegProfesionales();//Instancia de negocios Profesionales, es un objeto
        private void LlenarDGV()

        {
            dgvpersonas.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = objNegAlum.listadoAlumnos("Todos");//Data set devuelve una lista, en este caso de alumnos cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    dgvpersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4],Convert.ToDateTime(dr[5]).ToShortDateString(), dr[6]);// 
                    //dgvpersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4],(dr[5]), dr[6]);// 
                }
            }
            else lblInformacion.Text = "No hay personas cargadas en el sistema";
        }
        private void Txtbox_a_obj()//metodo para tomar los datos del formulario/text box y colocar los atributos a la instacia de la clase, Toma los datos de ls txbox y utiliza las propiedades de la clase docente
        {
            entAlum.Dni = System.Convert.ToInt32(txtDNI.Text);
            entAlum.Nombre = txtNombre.Text;
            entAlum.Apellido = txtApellido.Text;
            char genero = new char();
            if (rbMasculino.Checked)
            {
                genero = 'm';
            }
            else if (rdFemenino.Checked)
            {
                genero = 'f';
            }
            else if (rdX.Checked)
            {
                genero = 'x';
            }
            entAlum.Sexo = genero;
            DateTime dt = this.dtpFecNacAlumno.Value.Date;

            entAlum.FechNac = dt;
                //objEntDoc.CodProf = Convert.ToInt32(txtCodigo.Text);
            entAlum.Carrera = cbxCarrera.SelectedItem.ToString();


        }
        
        private void Limpiar()
        {
            btnVolver.Visible = false;
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            //txtCodigo.Text = string.Empty;
            cbxCarrera.Text = "Elija una carrera";
            
        }
        
        private void Ds_a_TxtBox(DataSet ds)
        {
            txtDNI.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["APELLIDO"].ToString();
            cbxCarrera.SelectedItem = ds.Tables[0].Rows[0]["CARRERA"].ToString();
            
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Limpiar();
            groupBox1.Visible = false;
            btnNuevo.Visible = true;
            btnVolver.Visible = false;
            btnModficar.Visible = false;
            btnBorrar.Visible = false;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            confirmar = true;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            btnModficar.Visible = false;
            btnBorrar.Visible = false;

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (confirmar == true)
            {
                int ngrabados = -1;//la utilizo para detectar si fue grabado exitosamente o no
                Txtbox_a_obj();
                ngrabados = objNegAlum.abmAlumnos("Alta", entAlum);//
                if (ngrabados == -1)
                {
                    lblInformacion.Text = "No se pudo grabar los datos en el sistema";
                }
                else
                {
                    lblInformacion.Text = "Se grabaron los datos con éxito";
                    LlenarDGV();
                    Limpiar();//Limpia los textBox
                    groupBox1.Visible = false;
                    btnNuevo.Visible = true;
                    btnBorrar.Visible = false;

                }

            }

            if (confirmar == false)
            {
                //groupBox1.Enabled = true;
                //btnBorrar.Visible = false;
                int nResultado = -1;
                Txtbox_a_obj();
                nResultado = objNegAlum.abmAlumnos("Modificar", entAlum);//Invoco a la capa de negocios


                if (nResultado != -1)
                {
                    lblInformacion.Text = "Los datos fueron modificados con éxito";
                    Limpiar();
                    LlenarDGV();
                    //txtCodigo.Enabled = true;
                }
                else
                {
                    lblInformacion.Text = ("Se produjo un error al intentar modificar los datos");
                }
            }

        }

        private void dgvpersonas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            btnBorrar.Visible = true;
            btnVolver.Visible = true;

            btnModficar.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Enabled = false;

            DataSet ds = new DataSet();
            entAlum.Legajo = Convert.ToInt32(dgvpersonas.CurrentRow.Cells[6].Value);
            //txtCodigo.Enabled = false;
            ds = objNegAlum.listadoAlumnos(entAlum.Legajo.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btnNuevo.Visible = false;
                lblInformacion.Text = string.Empty;
            }
        }//Para modificar los datos haciendo click en la celda del dgv

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

            Limpiar();
            groupBox1.Visible = false;
            btnNuevo.Visible = true;
        }

        private void btnModficar_Click_1(object sender, EventArgs e)
        {

            confirmar = false;
            groupBox1.Enabled = true;
            btnModficar.Visible = false;
            btnBorrar.Visible = false;

        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            int nResultado = -1;
            Txtbox_a_obj();
            nResultado = objNegAlum.abmAlumnos("Borrar", entAlum);//Invoco a la capa de negocios


            if (nResultado != -1)
            {
                lblInformacion.Text = "Los datos fueron modificados con éxito";
                Limpiar();
                LlenarDGV();
                //txtCodigo.Enabled = true;
            }
            else
            {
                lblInformacion.Text = ("Se produjo un error al intentar modificar los datos");
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
    }

