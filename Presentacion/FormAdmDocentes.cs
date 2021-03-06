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
            #region Formato DGV
            dgvpersonas.ColumnCount = 7;
            dgvpersonas.Columns[0].HeaderText = "DNI";
            dgvpersonas.Columns[1].HeaderText = "NOMBRE";
            dgvpersonas.Columns[2].HeaderText = "APELLIDO";
            dgvpersonas.Columns[3].HeaderText = "GENERO";
            dgvpersonas.Columns[4].HeaderText = "NACIMIENTO";
            dgvpersonas.Columns[5].HeaderText = "CODIGO";
            dgvpersonas.Columns[6].HeaderText = "MATERIA";
            dgvpersonas.Columns[0].Width = 100;
            dgvpersonas.Columns[1].Width = 200;
            dgvpersonas.Columns[2].Width = 200;
            dgvpersonas.Columns[3].Width = 100;
            dgvpersonas.Columns[4].Width = 200;
            dgvpersonas.Columns[5].Width = 100;
            dgvpersonas.Columns[6].Width = 200;
            #endregion
            LlenarDGV();
            btnBorrar.Visible = false;
            btnModficar.Visible = false;
            string[] año = new string[3];
            año[0] = "1";
            año[1] = "2";
            año[2] = "3";
            string[] Carreras = new string[9];
            cbxAño.DataSource = año;
            Carreras[0] = "Administración y Gestión Publica";
            Carreras[1] = "Desarrollo de Software";
            Carreras[2] = "Enfermería";
            Carreras[3] = "Gestión ambiental";
            Carreras[4] = "Gestion y Administracion de las Organizaciones";
            Carreras[5] = "Gestion y Mantenimiento Industrial";
            Carreras[6] = "Optica y Contactologia";
            Carreras[7] = "Protesis Dental";
            Carreras[8] = "Seguridad e Higiene Laboral";
            cbxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAño.DropDownStyle = ComboBoxStyle.DropDownList;


        }


        string[] materias1 = new string[6];
        string[] materias2 = new string[6];
        string[] materias3 = new string[7];



        bool confirmar;

        public Docente objEntDoc = new Docente();//Instancia de Docente, es un objeto

        public NegProfesionales objNegDoc = new NegProfesionales();//Instancia de negocios Profesionales, es un objeto

        #region Métodos
        private void LlenarDGV()

        {
            dgvpersonas.Rows.Clear();//vacia el DGV
            DataSet ds = new DataSet();
            ds = objNegDoc.listadoDocentes("Todos");//Data set devuelve una lista, en este caso de docentes cargados, como el argumento es "Todos", me devolvera todos las personas cargadas
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)//Lo que muestra esta en dr[0].ToString(), dr[1].ToString(),y asi sucesivamente
                {
                    if (Convert.ToString(dr[3]) == "M")
                    {
                        dr[3] = "Masculino";
                    }
                    if (Convert.ToString(dr[3]) == "F")
                    {
                        dr[3] = "Femenino";
                    }
                    if (Convert.ToString(dr[3]) == "X")
                    {
                        dr[3] = "Indefinido";
                    }
                    dgvpersonas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], Convert.ToDateTime(dr[4]).ToShortDateString(), dr[5], dr[6]);////Rellena el dgv por cada ds que trae de la bd
                }
            }
            else lblInformacion.Text = "No hay personas cargadas en el sistema";
        }//Metodo para llenar el dgv con datos de la bd
        private void Txtbox_a_obj()//metodo para tomar los datos del formulario/text box y colocar los atributos a la instacia de la clase, Toma los datos de ls txbox y utiliza las propiedades de la clase docente
        {
            objEntDoc.Dni = System.Convert.ToInt32(textBoxDocumento.Text);
            objEntDoc.Nombre = txtNombre.Text;
            objEntDoc.Apellido = txtApellido.Text;
            char Genero = new char();
            if (rbMasculino.Checked)
            {
                Genero = 'M';
            }
            else if (rdFemenino.Checked)
            {
                Genero = 'F';
            }
            else if (rdX.Checked)
            {
                Genero = 'X';
            }
            objEntDoc.Sexo = Genero;
            objEntDoc.FechNac = dtpFecNac.Value;
            //objEntDoc.CodProf = Convert.ToInt32(txtCodigo.Text);
            objEntDoc.Materia = cbxMateria.SelectedItem.ToString();


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            confirmar = true;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            btnModficar.Visible = false;
            btnBorrar.Visible = false;



        }//Evento que desencadena el click en el boton "Nuevo"
        private void Limpiar()//Limpia y vacia los textbox.
        {
            btnVolver.Visible = false;
            textBoxDocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            //txtCodigo.Text = string.Empty;
            cbxMateria.Text = "Elija una materia";
            cbxAño.Text = "Elija un año";
        }

        private void dgvpersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnBorrar.Visible = true;
            btnVolver.Visible = true;

            btnModficar.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Enabled = false;

            DataSet ds = new DataSet();
            objEntDoc.CodProf = Convert.ToInt32(dgvpersonas.CurrentRow.Cells[5].Value);
            //txtCodigo.Enabled = false;
            ds = objNegDoc.listadoDocentes(objEntDoc.CodProf.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btnNuevo.Visible = false;
                lblInformacion.Text = string.Empty;
            }
        }//Para modificar los datos haciendo click en la celda del dgv
        private void Ds_a_TxtBox(DataSet ds)
        {
            textBoxDocumento.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["APELLIDO"].ToString();
            cbxMateria.SelectedItem = ds.Tables[0].Rows[0]["MATERIA"].ToString();

        }
        #endregion
        #region Eventos Click & Key Press
        private void btnModficar_Click(object sender, EventArgs e)
        {
            confirmar = false;
            groupBox1.Enabled = true;
            btnModficar.Visible = false;
            btnBorrar.Visible = false;

        }//Evento que desencadena el click en el boton "Modificar"

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            Txtbox_a_obj();
            nResultado = objNegDoc.abmDocentes("Borrar", objEntDoc);//Invoco a la capa de negocios


            if (nResultado != -1)
            {
                lblInformacion.Text = "Los datos fueron modificados con éxito";
                Limpiar();
                LlenarDGV();
                groupBox1.Visible = false;
                btnBorrar.Visible = false;
                btnModficar.Visible = false;
                btnNuevo.Visible = true;
                //txtCodigo.Enabled = true;
            }
            else
            {
                lblInformacion.Text = ("Se produjo un error al intentar modificar los datos");
            }

        }//Evento que desencadena el click en el boton "Borrar"

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (confirmar == true)
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
                nResultado = objNegDoc.abmDocentes("Modificar", objEntDoc);//Invoco a la capa de negocios


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
            Limpiar();
            groupBox1.Visible = false;

        }//Evento que desencadena el click en el boton "Confirmar"

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            groupBox1.Visible = false;
            btnNuevo.Visible = true;
        }//Evento que desencadena el click en el boton "cancelar"

        private void cbxAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAño.SelectedIndex == 0)
            {
                materias1[1] = "Sistemas y Organizaciones";
                materias1[2] = "Arquitectura de Computadoras";
                materias1[3] = "Programacion I";
                materias1[4] = "Ingles";
                materias1[0] = "Matematica y Logica";
                materias1[5] = "Lengua y Comunicacion";
                cbxMateria.DataSource = materias1;

            }
            if (cbxAño.SelectedIndex == 1)
            {
                materias2[0] = "Sistemas Operativos";
                materias2[1] = "Matematica Aplicada";
                materias2[2] = "Programacion II";
                materias2[3] = "Modelado de Sistemas";
                materias2[4] = "Base de Datos";
                materias2[5] = "Practica Profesionalizante I";
                cbxMateria.DataSource = materias2;

            }
            if (cbxAño.SelectedIndex == 2)
            {
                materias3[0] = "Interfaz de Usuario";
                materias3[1] = "Redes";
                materias3[2] = "Ingenieria de Software";
                materias3[3] = "Programacion III";
                materias3[4] = "Validacion y Verificacion de programas";
                materias3[5] = "Etica y Deontologia Profesional";
                materias3[6] = "Practica Profesionaizante II";
                cbxMateria.DataSource = materias3;
            }
        }//Evento que se desencadena cuando cambio la seleccion del combobox año

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Limpiar();
            groupBox1.Visible = false;
            btnNuevo.Visible = true;
            btnVolver.Visible = false;
            btnModficar.Visible = false;
            btnBorrar.Visible = false;

        }//Evento que desencadena el click en el boton "Volver"



        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)//Validar ingreso solo letras
        {
            if (txtNombre.Text.Length <= 49)
            {

                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            else
            {

                MessageBox.Show("Solo 50 caracteres disponibles");
                txtNombre.Text = string.Empty;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)//Validar ingreso solo letras
        {
            if (txtNombre.Text.Length <= 49)
            {

                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            else
            {

                MessageBox.Show("Solo 50 caracteres disponibles");
                txtNombre.Text = string.Empty;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)//Para volver al Inicio, eleccion de formularios estudiantes o docentes
        {
            this.Close();

        }

        private void FormAdmDocentes_Load(object sender, EventArgs e)
        {

        }


       

        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxDocumento.Text.Length <= 7)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                    

                }
            }
            else
            {
                
                MessageBox.Show("Solo 8 digitos disponibles");
                textBoxDocumento.Text = string.Empty;
            }
            

        }//Validar solo numeros, 8 digitos
        #endregion
    }
}
