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
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolfrmUser,
            this.toolfrmProjeto,
            this.toolfrmSistema});
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
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(756, 352);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
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
    }
}