
namespace Presentacion
{
    partial class frmInicio
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEst = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.lblGestion = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEst);
            this.groupBox2.Controls.Add(this.btnDoc);
            this.groupBox2.Controls.Add(this.lblGestion);
            this.groupBox2.Location = new System.Drawing.Point(136, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 120);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnEst
            // 
            this.btnEst.Location = new System.Drawing.Point(34, 78);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(131, 26);
            this.btnEst.TabIndex = 28;
            this.btnEst.Text = "ESTUDIANTES";
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(34, 46);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(131, 26);
            this.btnDoc.TabIndex = 27;
            this.btnDoc.Text = "DOCENTES";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblGestion.Location = new System.Drawing.Point(0, 0);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(183, 32);
            this.lblGestion.TabIndex = 8;
            this.lblGestion.Text = "Gestión Instituto";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 295);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label lblGestion;
    }
}