namespace Formulario
{
    partial class CursoProfessorFormulario
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
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.gbCursoProfessor = new System.Windows.Forms.GroupBox();
            this.dgvCursoProfessor = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.gpProfessor = new System.Windows.Forms.GroupBox();
            this.gbCurso.SuspendLayout();
            this.gbCursoProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursoProfessor)).BeginInit();
            this.gpProfessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.lblCurso);
            this.gbCurso.Controls.Add(this.cmbCurso);
            this.gbCurso.Location = new System.Drawing.Point(7, 9);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(537, 69);
            this.gbCurso.TabIndex = 16;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Curso";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(2, 16);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(44, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "* Curso:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(5, 32);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(526, 21);
            this.cmbCurso.TabIndex = 12;
            // 
            // gbCursoProfessor
            // 
            this.gbCursoProfessor.Controls.Add(this.dgvCursoProfessor);
            this.gbCursoProfessor.Location = new System.Drawing.Point(7, 188);
            this.gbCursoProfessor.Name = "gbCursoProfessor";
            this.gbCursoProfessor.Size = new System.Drawing.Size(538, 180);
            this.gbCursoProfessor.TabIndex = 19;
            this.gbCursoProfessor.TabStop = false;
            this.gbCursoProfessor.Text = "Cursos / Professores";
            // 
            // dgvCursoProfessor
            // 
            this.dgvCursoProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursoProfessor.Location = new System.Drawing.Point(6, 19);
            this.dgvCursoProfessor.Name = "dgvCursoProfessor";
            this.dgvCursoProfessor.Size = new System.Drawing.Size(526, 150);
            this.dgvCursoProfessor.TabIndex = 0;
            this.dgvCursoProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursoProfessor_CellContentClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(87, 159);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Professor:";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(5, 32);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(526, 21);
            this.cmbProfessor.TabIndex = 12;
            // 
            // gpProfessor
            // 
            this.gpProfessor.Controls.Add(this.label1);
            this.gpProfessor.Controls.Add(this.cmbProfessor);
            this.gpProfessor.Location = new System.Drawing.Point(7, 84);
            this.gpProfessor.Name = "gpProfessor";
            this.gpProfessor.Size = new System.Drawing.Size(537, 69);
            this.gpProfessor.TabIndex = 17;
            this.gpProfessor.TabStop = false;
            this.gpProfessor.Text = "Professor";
            // 
            // CursoProfessorFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 370);
            this.Controls.Add(this.gpProfessor);
            this.Controls.Add(this.gbCurso);
            this.Controls.Add(this.gbCursoProfessor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CursoProfessorFormulario";
            this.Text = "Gerenciar Curso / Professor";
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.gbCursoProfessor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursoProfessor)).EndInit();
            this.gpProfessor.ResumeLayout(false);
            this.gpProfessor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.GroupBox gbCursoProfessor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.GroupBox gpProfessor;
        private System.Windows.Forms.DataGridView dgvCursoProfessor;
    }
}