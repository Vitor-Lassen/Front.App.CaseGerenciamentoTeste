namespace Front.App.CaseGerenciamentoTeste.View
{
    partial class frmSelectProj
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
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.dgvProjetos = new System.Windows.Forms.DataGridView();
            this.btnConsultaProj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetalhes);
            this.groupBox1.Controls.Add(this.dgvProjetos);
            this.groupBox1.Controls.Add(this.btnConsultaProj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 283);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Projeto";
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(497, 248);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 9;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // dgvProjetos
            // 
            this.dgvProjetos.AllowUserToAddRows = false;
            this.dgvProjetos.AllowUserToDeleteRows = false;
            this.dgvProjetos.AllowUserToOrderColumns = true;
            this.dgvProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjetos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjetos.Location = new System.Drawing.Point(19, 56);
            this.dgvProjetos.Name = "dgvProjetos";
            this.dgvProjetos.ReadOnly = true;
            this.dgvProjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjetos.Size = new System.Drawing.Size(553, 186);
            this.dgvProjetos.TabIndex = 8;
            // 
            // btnConsultaProj
            // 
            this.btnConsultaProj.Location = new System.Drawing.Point(497, 28);
            this.btnConsultaProj.Name = "btnConsultaProj";
            this.btnConsultaProj.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaProj.TabIndex = 7;
            this.btnConsultaProj.Text = "Consultar";
            this.btnConsultaProj.UseVisualStyleBackColor = true;
            this.btnConsultaProj.Click += new System.EventHandler(this.btnConsultaProj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(434, 20);
            this.txtNome.TabIndex = 5;
            // 
            // frmSelectProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(616, 307);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSelectProj";
            this.Text = "frmSelectProj";
            this.Load += new System.EventHandler(this.frmSelectProj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.DataGridView dgvProjetos;
        private System.Windows.Forms.Button btnConsultaProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
    }
}