namespace Front.App.CaseGerenciamentoTeste.View
{
    partial class frmSelectSistema
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnConsultaNome = new System.Windows.Forms.Button();
            this.dgvSistemas = new System.Windows.Forms.DataGridView();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnConsultaSigla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(378, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnConsultaNome
            // 
            this.btnConsultaNome.Location = new System.Drawing.Point(462, 20);
            this.btnConsultaNome.Name = "btnConsultaNome";
            this.btnConsultaNome.Size = new System.Drawing.Size(75, 22);
            this.btnConsultaNome.TabIndex = 2;
            this.btnConsultaNome.Text = "Consulta";
            this.btnConsultaNome.UseVisualStyleBackColor = true;
            this.btnConsultaNome.Click += new System.EventHandler(this.btnConsultaNome_Click);
            // 
            // dgvSistemas
            // 
            this.dgvSistemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSistemas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSistemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistemas.Location = new System.Drawing.Point(40, 102);
            this.dgvSistemas.Name = "dgvSistemas";
            this.dgvSistemas.Size = new System.Drawing.Size(497, 150);
            this.dgvSistemas.TabIndex = 3;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(78, 65);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(378, 20);
            this.txtSigla.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sigla:";
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(462, 258);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 6;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnConsultaSigla
            // 
            this.btnConsultaSigla.Location = new System.Drawing.Point(462, 63);
            this.btnConsultaSigla.Name = "btnConsultaSigla";
            this.btnConsultaSigla.Size = new System.Drawing.Size(75, 22);
            this.btnConsultaSigla.TabIndex = 7;
            this.btnConsultaSigla.Text = "Consulta";
            this.btnConsultaSigla.UseVisualStyleBackColor = true;
            this.btnConsultaSigla.Click += new System.EventHandler(this.btnConsultaSigla_Click);
            // 
            // frmSelectSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(579, 300);
            this.Controls.Add(this.btnConsultaSigla);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.dgvSistemas);
            this.Controls.Add(this.btnConsultaNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmSelectSistema";
            this.Text = "frmSelectSistema";
            this.Load += new System.EventHandler(this.frmSelectSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnConsultaNome;
        private System.Windows.Forms.DataGridView dgvSistemas;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnConsultaSigla;
    }
}