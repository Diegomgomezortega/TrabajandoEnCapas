
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnModficar = new System.Windows.Forms.Button();
            this.dgvpersonas = new System.Windows.Forms.DataGridView();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblGestion = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(161, 133);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 162);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 133);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 162);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(21, 315);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnModficar
            // 
            this.btnModficar.Location = new System.Drawing.Point(125, 315);
            this.btnModficar.Name = "btnModficar";
            this.btnModficar.Size = new System.Drawing.Size(75, 23);
            this.btnModficar.TabIndex = 6;
            this.btnModficar.Text = "Modificar";
            this.btnModficar.UseVisualStyleBackColor = true;
            this.btnModficar.Click += new System.EventHandler(this.btnModficar_Click);
            // 
            // dgvpersonas
            // 
            this.dgvpersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonas.Location = new System.Drawing.Point(21, 418);
            this.dgvpersonas.Name = "dgvpersonas";
            this.dgvpersonas.RowTemplate.Height = 25;
            this.dgvpersonas.Size = new System.Drawing.Size(354, 150);
            this.dgvpersonas.TabIndex = 6;
            this.dgvpersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonas_CellClick);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(21, 379);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(72, 15);
            this.lblInformacion.TabIndex = 7;
            this.lblInformacion.Text = "Información";
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblGestion.Location = new System.Drawing.Point(256, 16);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(267, 32);
            this.lblGestion.TabIndex = 8;
            this.lblGestion.Text = "Gestión Planilla Instituto";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(21, 191);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(47, 15);
            this.lblMateria.TabIndex = 9;
            this.lblMateria.Text = "Materia";
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Location = new System.Drawing.Point(21, 220);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(103, 15);
            this.lblFecNac.TabIndex = 10;
            this.lblFecNac.Text = "Fecha Nacimiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 249);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 15);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(161, 191);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(229, 23);
            this.txtMateria.TabIndex = 2;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(161, 249);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(39, 23);
            this.txtGenero.TabIndex = 4;
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(161, 220);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(200, 23);
            this.dtpFecNac.TabIndex = 15;
            this.dtpFecNac.Value = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            // 
            // FormAdmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.dtpFecNac);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFecNac);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.dgvpersonas);
            this.Controls.Add(this.btnModficar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FormAdmDocentes";
            this.Text = "Gestion Instituto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnModficar;
        private System.Windows.Forms.DataGridView dgvpersonas;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
    }
}