﻿
namespace Presentacion
{
    partial class FormAdmDocentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModficar = new System.Windows.Forms.Button();
            this.dgvpersonas = new System.Windows.Forms.DataGridView();
            this.lblGestion = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.rdX = new System.Windows.Forms.RadioButton();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxAño = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(211, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 23);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(152, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(372, 81);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 26);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnModficar
            // 
            this.btnModficar.Location = new System.Drawing.Point(645, 81);
            this.btnModficar.Name = "btnModficar";
            this.btnModficar.Size = new System.Drawing.Size(131, 26);
            this.btnModficar.TabIndex = 6;
            this.btnModficar.Text = "Modificar";
            this.btnModficar.UseVisualStyleBackColor = true;
            this.btnModficar.Click += new System.EventHandler(this.btnModficar_Click);
            // 
            // dgvpersonas
            // 
            this.dgvpersonas.AllowUserToAddRows = false;
            this.dgvpersonas.AllowUserToDeleteRows = false;
            this.dgvpersonas.AllowUserToResizeColumns = false;
            this.dgvpersonas.AllowUserToResizeRows = false;
            this.dgvpersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvpersonas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvpersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpersonas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvpersonas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvpersonas.Location = new System.Drawing.Point(22, 387);
            this.dgvpersonas.Name = "dgvpersonas";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvpersonas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvpersonas.RowTemplate.Height = 25;
            this.dgvpersonas.Size = new System.Drawing.Size(1034, 150);
            this.dgvpersonas.TabIndex = 6;
            this.dgvpersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonas_CellClick);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblGestion.Location = new System.Drawing.Point(22, 75);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(267, 32);
            this.lblGestion.TabIndex = 8;
            this.lblGestion.Text = "Gestión Planilla Instituto";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(753, 87);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 15);
            this.lblMateria.TabIndex = 9;
            this.lblMateria.Text = "MATERIA";
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Location = new System.Drawing.Point(695, 41);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(118, 15);
            this.lblFecNac.TabIndex = 10;
            this.lblFecNac.Text = "FECHA NACIMIENTO";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(12, 86);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 15);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "GENERO";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(819, 38);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(229, 23);
            this.dtpFecNac.TabIndex = 21;
            this.dtpFecNac.Value = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(782, 81);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(131, 26);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 41);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 17;
            this.lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(45, 38);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 18;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(387, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 15);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(453, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(229, 23);
            this.txtApellido.TabIndex = 20;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(89, 86);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 22;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Location = new System.Drawing.Point(176, 86);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdFemenino.TabIndex = 23;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // rdX
            // 
            this.rdX.AutoSize = true;
            this.rdX.Location = new System.Drawing.Point(264, 86);
            this.rdX.Name = "rdX";
            this.rdX.Size = new System.Drawing.Size(32, 19);
            this.rdX.TabIndex = 24;
            this.rdX.TabStop = true;
            this.rdX.Text = "X";
            this.rdX.UseVisualStyleBackColor = true;
            // 
            // cbxMateria
            // 
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Items.AddRange(new object[] {
            "PROGRAMACIÓN",
            "MATEMATICA APLICADA",
            "PRÁCTICA I",
            "BASE DE DATOS",
            "SISTEMAS OPERATIVOS",
            "MODELADO DE SISTEMAS"});
            this.cbxMateria.Location = new System.Drawing.Point(819, 83);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(229, 23);
            this.cbxMateria.TabIndex = 26;
            this.cbxMateria.Text = "Elija una materia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxAño);
            this.groupBox1.Controls.Add(this.lblAño);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.cbxMateria);
            this.groupBox1.Controls.Add(this.lblInformacion);
            this.groupBox1.Controls.Add(this.rdX);
            this.groupBox1.Controls.Add(this.rdFemenino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.dtpFecNac);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.lblFecNac);
            this.groupBox1.Controls.Add(this.lblMateria);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(22, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1089, 246);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // cbxAño
            // 
            this.cbxAño.FormattingEnabled = true;
            this.cbxAño.Items.AddRange(new object[] {
            "PROGRAMACIÓN",
            "MATEMATICA APLICADA",
            "PRÁCTICA I",
            "BASE DE DATOS",
            "SISTEMAS OPERATIVOS",
            "MODELADO DE SISTEMAS"});
            this.cbxAño.Location = new System.Drawing.Point(453, 86);
            this.cbxAño.Name = "cbxAño";
            this.cbxAño.Size = new System.Drawing.Size(229, 23);
            this.cbxAño.TabIndex = 25;
            this.cbxAño.Text = "Elija un año";
            this.cbxAño.SelectedIndexChanged += new System.EventHandler(this.cbxAño_SelectedIndexChanged);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(387, 90);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(33, 15);
            this.lblAño.TabIndex = 28;
            this.lblAño.Text = "AÑO";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(385, 195);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(131, 31);
            this.btnConfirmar.TabIndex = 27;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(522, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 31);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(479, 165);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(72, 15);
            this.lblInformacion.TabIndex = 7;
            this.lblInformacion.Text = "Información";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(509, 81);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 26);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormAdmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 633);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.dgvpersonas);
            this.Controls.Add(this.btnModficar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FormAdmDocentes";
            this.Text = "Gestion Instituto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModficar;
        private System.Windows.Forms.DataGridView dgvpersonas;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.RadioButton rdX;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnVolver;
    }
}