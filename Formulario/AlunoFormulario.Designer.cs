namespace Formulario
{
    partial class AlunoFormulario
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
            this.txtRa = new System.Windows.Forms.TextBox();
            this.lblRa = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtIdEndereco = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblIdEndereco = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbAlunos = new System.Windows.Forms.GroupBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.gbCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtId);
            this.gbDadosPessoais.Controls.Add(this.lblId);
            this.gbDadosPessoais.Controls.Add(this.txtRa);
            this.gbDadosPessoais.Controls.Add(this.lblRa);
            this.gbDadosPessoais.Controls.Add(this.txtEmail);
            this.gbDadosPessoais.Controls.Add(this.txtTelefone);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Controls.Add(this.lblEmail);
            this.gbDadosPessoais.Controls.Add(this.txtCpf);
            this.gbDadosPessoais.Controls.Add(this.lblCpf);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(13, 13);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(537, 111);
            this.gbDadosPessoais.TabIndex = 0;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
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
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(131, 75);
            this.txtRa.MaxLength = 30;
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(119, 20);
            this.txtRa.TabIndex = 4;
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(128, 59);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(32, 13);
            this.lblRa.TabIndex = 8;
            this.lblRa.Text = "* RA:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 75);
            this.txtEmail.MaxLength = 70;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 75);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(119, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(3, 59);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(59, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "* Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(253, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "* E-mail:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(383, 32);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(148, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(380, 16);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "* CPF:";
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
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtIdEndereco);
            this.gbEndereco.Controls.Add(this.txtUf);
            this.gbEndereco.Controls.Add(this.lblIdEndereco);
            this.gbEndereco.Controls.Add(this.lblUf);
            this.gbEndereco.Controls.Add(this.txtLocalidade);
            this.gbEndereco.Controls.Add(this.lblLocalidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.txtCep);
            this.gbEndereco.Controls.Add(this.lblCep);
            this.gbEndereco.Controls.Add(this.lblComplemento);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txtLogradouro);
            this.gbEndereco.Controls.Add(this.lblLogradouro);
            this.gbEndereco.Location = new System.Drawing.Point(12, 130);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(538, 150);
            this.gbEndereco.TabIndex = 9;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // txtIdEndereco
            // 
            this.txtIdEndereco.Enabled = false;
            this.txtIdEndereco.Location = new System.Drawing.Point(6, 36);
            this.txtIdEndereco.Name = "txtIdEndereco";
            this.txtIdEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtIdEndereco.TabIndex = 12;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(282, 114);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(59, 20);
            this.txtUf.TabIndex = 11;
            // 
            // lblIdEndereco
            // 
            this.lblIdEndereco.AutoSize = true;
            this.lblIdEndereco.Location = new System.Drawing.Point(4, 20);
            this.lblIdEndereco.Name = "lblIdEndereco";
            this.lblIdEndereco.Size = new System.Drawing.Size(21, 13);
            this.lblIdEndereco.TabIndex = 11;
            this.lblIdEndereco.Text = "ID:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(279, 98);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(31, 13);
            this.lblUf.TabIndex = 12;
            this.lblUf.Text = "* UF:";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(6, 114);
            this.txtLocalidade.MaxLength = 100;
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(270, 20);
            this.txtLocalidade.TabIndex = 9;
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(3, 98);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(69, 13);
            this.lblLocalidade.TabIndex = 10;
            this.lblLocalidade.Text = "* Localidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 75);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(270, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(3, 59);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "* Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(282, 75);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(250, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(435, 36);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(97, 20);
            this.txtCep.TabIndex = 3;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(432, 20);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 13);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "* CEP:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(279, 59);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 6;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(354, 36);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(75, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(351, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "* Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(112, 36);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(236, 20);
            this.txtLogradouro.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(113, 20);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(71, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "* Logradouro:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 361);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(94, 361);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbAlunos
            // 
            this.gbAlunos.Controls.Add(this.dgvAlunos);
            this.gbAlunos.Location = new System.Drawing.Point(13, 390);
            this.gbAlunos.Name = "gbAlunos";
            this.gbAlunos.Size = new System.Drawing.Size(538, 180);
            this.gbAlunos.TabIndex = 15;
            this.gbAlunos.TabStop = false;
            this.gbAlunos.Text = "Alunos";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(10, 19);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(522, 155);
            this.dgvAlunos.TabIndex = 18;
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.lblCurso);
            this.gbCurso.Controls.Add(this.cmbCurso);
            this.gbCurso.Location = new System.Drawing.Point(13, 286);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(537, 69);
            this.gbCurso.TabIndex = 13;
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
            this.cmbCurso.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(5, 32);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(526, 21);
            this.cmbCurso.TabIndex = 12;
            // 
            // AlunoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 585);
            this.Controls.Add(this.gbCurso);
            this.Controls.Add(this.gbAlunos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlunoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Alunos";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbAlunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbAlunos;
        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdEndereco;
        private System.Windows.Forms.Label lblIdEndereco;
    }
}