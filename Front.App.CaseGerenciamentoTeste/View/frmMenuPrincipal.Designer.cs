namespace Front.App.CaseGerenciamentoTeste.View
{
    partial class frmMenuPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolfrmUser = new System.Windows.Forms.ToolStripLabel();
            this.toolfrmProjeto = new System.Windows.Forms.ToolStripLabel();
            this.toolfrmSistema = new System.Windows.Forms.ToolStripLabel();
            this.toolfrmModelagem = new System.Windows.Forms.ToolStripLabel();
            this.toolFechar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolfrmUser,
            this.toolfrmProjeto,
            this.toolfrmSistema,
            this.toolfrmModelagem,
            this.toolFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolfrmUser
            // 
            this.toolfrmUser.Name = "toolfrmUser";
            this.toolfrmUser.Size = new System.Drawing.Size(47, 22);
            this.toolfrmUser.Text = "Usuario";
            this.toolfrmUser.Click += new System.EventHandler(this.toolfrmUser_Click);
            // 
            // toolfrmProjeto
            // 
            this.toolfrmProjeto.Name = "toolfrmProjeto";
            this.toolfrmProjeto.Size = new System.Drawing.Size(45, 22);
            this.toolfrmProjeto.Text = "Projeto";
            this.toolfrmProjeto.Click += new System.EventHandler(this.toolfrmProjeto_Click);
            // 
            // toolfrmSistema
            // 
            this.toolfrmSistema.Name = "toolfrmSistema";
            this.toolfrmSistema.Size = new System.Drawing.Size(48, 22);
            this.toolfrmSistema.Text = "Sistema";
            this.toolfrmSistema.Click += new System.EventHandler(this.toolfrmSistema_Click);
            // 
            // toolfrmModelagem
            // 
            this.toolfrmModelagem.Name = "toolfrmModelagem";
            this.toolfrmModelagem.Size = new System.Drawing.Size(71, 22);
            this.toolfrmModelagem.Text = "Modelagem";
            this.toolfrmModelagem.Click += new System.EventHandler(this.toolfrmModelagem_Click);
            // 
            // toolFechar
            // 
            this.toolFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolFechar.Name = "toolFechar";
            this.toolFechar.Size = new System.Drawing.Size(50, 22);
            this.toolFechar.Text = "Encerrar";
            this.toolFechar.Click += new System.EventHandler(this.toolFechar_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(756, 352);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolfrmUser;
        private System.Windows.Forms.ToolStripLabel toolfrmProjeto;
        private System.Windows.Forms.ToolStripLabel toolfrmSistema;
        private System.Windows.Forms.ToolStripLabel toolfrmModelagem;
        private System.Windows.Forms.ToolStripLabel toolFechar;
    }
}