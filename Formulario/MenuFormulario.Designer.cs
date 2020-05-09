namespace Formulario
{
    partial class MenuFormulario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCursoProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAluno,
            this.tsmiProfessor,
            this.tsmiCurso,
            this.tsmiCursoProfessor});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastroToolStripMenuItem.Text = "Gerenciar";
            // 
            // tsmiAluno
            // 
            this.tsmiAluno.Name = "tsmiAluno";
            this.tsmiAluno.Size = new System.Drawing.Size(180, 22);
            this.tsmiAluno.Text = "Aluno";
            this.tsmiAluno.Click += new System.EventHandler(this.tsmiAluno_Click);
            // 
            // tsmiProfessor
            // 
            this.tsmiProfessor.Name = "tsmiProfessor";
            this.tsmiProfessor.Size = new System.Drawing.Size(180, 22);
            this.tsmiProfessor.Text = "Professor";
            this.tsmiProfessor.Click += new System.EventHandler(this.tsmiProfessor_Click);
            // 
            // tsmiCurso
            // 
            this.tsmiCurso.CheckOnClick = true;
            this.tsmiCurso.Name = "tsmiCurso";
            this.tsmiCurso.Size = new System.Drawing.Size(180, 22);
            this.tsmiCurso.Text = "Curso";
            this.tsmiCurso.Click += new System.EventHandler(this.tsmiCurso_Click);
            // 
            // tsmiCursoProfessor
            // 
            this.tsmiCursoProfessor.Name = "tsmiCursoProfessor";
            this.tsmiCursoProfessor.Size = new System.Drawing.Size(180, 22);
            this.tsmiCursoProfessor.Text = "Curso / Professor";
            this.tsmiCursoProfessor.Click += new System.EventHandler(this.tsmiCursoProfessor_Click);
            // 
            // MenuFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Cursos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfessor;
        private System.Windows.Forms.ToolStripMenuItem tsmiAluno;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurso;
        private System.Windows.Forms.ToolStripMenuItem tsmiCursoProfessor;
    }
}