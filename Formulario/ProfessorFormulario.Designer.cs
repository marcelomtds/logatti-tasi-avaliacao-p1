namespace Formulario
{
    partial class ProfessorFormulario
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtIdEndereco = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblIdEndereco = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            this.gbProfessores = new System.Windows.Forms.GroupBox();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.gbProfessores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(7, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(7, 71);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(119, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // txtIdEndereco
            // 
            this.txtIdEndereco.Enabled = false;
            this.txtIdEndereco.Location = new System.Drawing.Point(5, 32);
            this.txtIdEndereco.Name = "txtIdEndereco";
            this.txtIdEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtIdEndereco.TabIndex = 12;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(281, 110);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(59, 20);
            this.txtUf.TabIndex = 11;
            // 
            // lblIdEndereco
            // 
            this.lblIdEndereco.AutoSize = true;
            this.lblIdEndereco.Location = new System.Drawing.Point(3, 16);
            this.lblIdEndereco.Name = "lblIdEndereco";
            this.lblIdEndereco.Size = new System.Drawing.Size(21, 13);
            this.lblIdEndereco.TabIndex = 11;
            this.lblIdEndereco.Text = "ID:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(278, 94);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(31, 13);
            this.lblUf.TabIndex = 12;
            this.lblUf.Text = "* UF:";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(5, 110);
            this.txtLocalidade.MaxLength = 100;
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(270, 20);
            this.txtLocalidade.TabIndex = 9;
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(2, 94);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(69, 13);
            this.lblLocalidade.TabIndex = 10;
            this.lblLocalidade.Text = "* Localidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(5, 71);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(270, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(2, 55);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "* Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(281, 71);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(250, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(383, 32);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(148, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(278, 55);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 6;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(353, 32);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(75, 20);
            this.txtNumero.TabIndex = 2;
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
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Location = new System.Drawing.Point(129, 55);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(49, 13);
            this.lblRa.TabIndex = 8;
            this.lblRa.Text = "* Salário:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(4, 55);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(59, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "* Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(254, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "* E-mail:";
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
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(434, 32);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(97, 20);
            this.txtCep.TabIndex = 3;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(431, 16);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 13);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "* CEP:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(350, 16);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "* Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(111, 32);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(236, 20);
            this.txtLogradouro.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 32);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 1;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtId);
            this.gbDadosPessoais.Controls.Add(this.lblId);
            this.gbDadosPessoais.Controls.Add(this.txtSalario);
            this.gbDadosPessoais.Controls.Add(this.lblRa);
            this.gbDadosPessoais.Controls.Add(this.txtEmail);
            this.gbDadosPessoais.Controls.Add(this.txtTelefone);
            this.gbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gbDadosPessoais.Controls.Add(this.lblEmail);
            this.gbDadosPessoais.Controls.Add(this.txtCpf);
            this.gbDadosPessoais.Controls.Add(this.lblCpf);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Location = new System.Drawing.Point(6, 9);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(537, 105);
            this.gbDadosPessoais.TabIndex = 16;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(132, 71);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(119, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(257, 71);
            this.txtEmail.MaxLength = 70;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 20);
            this.txtEmail.TabIndex = 5;
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
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(112, 16);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(71, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "* Logradouro:";
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
            this.gbEndereco.Location = new System.Drawing.Point(6, 120);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(538, 144);
            this.gbEndereco.TabIndex = 17;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(87, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 270);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessores.Location = new System.Drawing.Point(9, 19);
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.Size = new System.Drawing.Size(522, 150);
            this.dgvProfessores.TabIndex = 0;
            this.dgvProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessores_CellContentClick);
            // 
            // gbProfessores
            // 
            this.gbProfessores.Controls.Add(this.dgvProfessores);
            this.gbProfessores.Location = new System.Drawing.Point(6, 299);
            this.gbProfessores.Name = "gbProfessores";
            this.gbProfessores.Size = new System.Drawing.Size(538, 180);
            this.gbProfessores.TabIndex = 21;
            this.gbProfessores.TabStop = false;
            this.gbProfessores.Text = "Professores";
            // 
            // ProfessorFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 490);
            this.Controls.Add(this.gbProfessores);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfessorFormulario";
            this.Text = "Gerenciar Professor";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.gbProfessores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtIdEndereco;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblIdEndereco;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvProfessores;
        private System.Windows.Forms.GroupBox gbProfessores;
    }
}