namespace Front.App.CaseGerenciamentoTeste.View
{
    partial class frmExecucao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnCenCaso = new System.Windows.Forms.Button();
            this.btnProjCen = new System.Windows.Forms.Button();
            this.cboCaso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCenario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExec);
            this.groupBox1.Controls.Add(this.btnCenCaso);
            this.groupBox1.Controls.Add(this.btnProjCen);
            this.groupBox1.Controls.Add(this.cboCaso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboCenario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboProj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Execução";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(331, 185);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 8;
            this.btnExec.Text = "Executar";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnCenCaso
            // 
            this.btnCenCaso.Location = new System.Drawing.Point(331, 111);
            this.btnCenCaso.Name = "btnCenCaso";
            this.btnCenCaso.Size = new System.Drawing.Size(75, 23);
            this.btnCenCaso.TabIndex = 7;
            this.btnCenCaso.Text = "Avançar";
            this.btnCenCaso.UseVisualStyleBackColor = true;
            this.btnCenCaso.Click += new System.EventHandler(this.btnCenCaso_Click);
            // 
            // btnProjCen
            // 
            this.btnProjCen.Location = new System.Drawing.Point(331, 44);
            this.btnProjCen.Name = "btnProjCen";
            this.btnProjCen.Size = new System.Drawing.Size(75, 23);
            this.btnProjCen.TabIndex = 6;
            this.btnProjCen.Text = "Avançar";
            this.btnProjCen.UseVisualStyleBackColor = true;
            this.btnProjCen.Click += new System.EventHandler(this.btnProjCen_Click);
            // 
            // cboCaso
            // 
            this.cboCaso.FormattingEnabled = true;
            this.cboCaso.Location = new System.Drawing.Point(58, 187);
            this.cboCaso.Name = "cboCaso";
            this.cboCaso.Size = new System.Drawing.Size(251, 21);
            this.cboCaso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caso:";
            // 
            // cboCenario
            // 
            this.cboCenario.FormattingEnabled = true;
            this.cboCenario.Location = new System.Drawing.Point(58, 113);
            this.cboCenario.Name = "cboCenario";
            this.cboCenario.Size = new System.Drawing.Size(251, 21);
            this.cboCenario.TabIndex = 3;
            this.cboCenario.SelectedIndexChanged += new System.EventHandler(this.cboCenario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cenário:";
            // 
            // cboProj
            // 
            this.cboProj.FormattingEnabled = true;
            this.cboProj.Location = new System.Drawing.Point(58, 46);
            this.cboProj.Name = "cboProj";
            this.cboProj.Size = new System.Drawing.Size(251, 21);
            this.cboProj.TabIndex = 1;
            this.cboProj.SelectedIndexChanged += new System.EventHandler(this.cboProj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projeto:";
            // 
            // frmExecucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(458, 252);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExecucao";
            this.Text = "frmExecucao";
            this.Load += new System.EventHandler(this.frmExecucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCaso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCenario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnCenCaso;
        private System.Windows.Forms.Button btnProjCen;
    }
}