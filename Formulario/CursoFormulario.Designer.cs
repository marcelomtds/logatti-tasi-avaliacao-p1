namespace Formulario
{
    partial class CursoFormulario
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
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtHorarioFim = new System.Windows.Forms.TextBox();
            this.lblRa = new System.Windows.Forms.Label();
            this.txtNumSala = new System.Windows.Forms.TextBox();
            this.txtHorarioInicio = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.dvgCursos = new System.Windows.Forms.DataGridView();
            this.gbDadosPessoais.SuspendLayout();
            this.gbCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtId);
            this.gbDadosPessoais.Controls.Add(this.lblId);
            this.gbDadosPessoais.Controls.Add(this.txtHorarioFim);
            this.gbDadosPessoais.Controls.Add(this.lblRa);
            this.gbDadosPessoais.Controls.Add(this.txtNumSala);
            this.gbDadosPessoais.Controls.Add(this.txtHorarioInicio);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Controls.Add(this.lblEmail);
            this.gbDadosPessoais.Controls.Add(this.txtCargaHoraria);
            this.gbDadosPessoais.Controls.Add(this.lblCpf);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(6, 8);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(537, 102);
            this.gbDadosPessoais.TabIndex = 22;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados do Curso";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(6, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID:";
            // 
            // txtHorarioFim
            // 
            this.txtHorarioFim.Location = new System.Drawing.Point(131, 71);
            this.txtHorarioFim.MaxLength = 5;
            this.txtHorarioFim.Name = "txtHorarioFim";
            this.txtHorarioFim.Size = new System.Drawing.Size(119, 20);
            this.txtHorarioFim.TabIndex = 4;
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(128, 55);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(77, 13);
            this.lblRa.TabIndex = 8;
            this.lblRa.Text = "* Horário FInal:";
            // 
            // txtNumSala
            // 
            this.txtNumSala.Location = new System.Drawing.Point(256, 71);
            this.txtNumSala.MaxLength = 10;
            this.txtNumSala.Name = "txtNumSala";
            this.txtNumSala.Size = new System.Drawing.Size(275, 20);
            this.txtNumSala.TabIndex = 5;
            // 
            // txtHorarioInicio
            // 
            this.txtHorarioInicio.Location = new System.Drawing.Point(6, 71);
            this.txtHorarioInicio.MaxLength = 5;
            this.txtHorarioInicio.Name = "txtHorarioInicio";
            this.txtHorarioInicio.Size = new System.Drawing.Size(119, 20);
            this.txtHorarioInicio.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(3, 55);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(81, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "* Horário Inicial:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(253, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "* Número da Sala:";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(383, 32);
            this.txtCargaHoraria.MaxLength = 11;
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(148, 20);
            this.txtCargaHoraria.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(380, 16);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(82, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "* Carga Horária:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 32);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(109, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "* Nome:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(87, 116);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 116);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.dvgCursos);
            this.gbCursos.Location = new System.Drawing.Point(6, 145);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(538, 180);
            this.gbCursos.TabIndex = 25;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // dvgCursos
            // 
            this.dvgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCursos.Location = new System.Drawing.Point(6, 18);
            this.dvgCursos.Name = "dvgCursos";
            this.dvgCursos.Size = new System.Drawing.Size(525, 150);
            this.dvgCursos.TabIndex = 0;
            this.dvgCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCursos_CellContentClick_1);
            // 
            // CursoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 337);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CursoFormulario";
            this.Text = "Gerenciar Curso";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtHorarioFim;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.TextBox txtNumSala;
        private System.Windows.Forms.TextBox txtHorarioInicio;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.DataGridView dvgCursos;
    }
}