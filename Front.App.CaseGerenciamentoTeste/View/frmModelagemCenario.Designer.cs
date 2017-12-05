namespace Front.App.CaseGerenciamentoTeste.View
{
    partial class frmModelagemCenario
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
            this.gbcenario = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtCodCen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboProj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelaCen = new System.Windows.Forms.Button();
            this.btnAvancaCen = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNomeCen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbcenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcenario
            // 
            this.gbcenario.Controls.Add(this.btnLimpar);
            this.gbcenario.Controls.Add(this.btnConsulta);
            this.gbcenario.Controls.Add(this.txtCodCen);
            this.gbcenario.Controls.Add(this.label5);
            this.gbcenario.Controls.Add(this.label4);
            this.gbcenario.Controls.Add(this.cboStatus);
            this.gbcenario.Controls.Add(this.cboProj);
            this.gbcenario.Controls.Add(this.label1);
            this.gbcenario.Controls.Add(this.btnCancelaCen);
            this.gbcenario.Controls.Add(this.btnAvancaCen);
            this.gbcenario.Controls.Add(this.txtDesc);
            this.gbcenario.Controls.Add(this.txtNomeCen);
            this.gbcenario.Controls.Add(this.label3);
            this.gbcenario.Controls.Add(this.label2);
            this.gbcenario.Location = new System.Drawing.Point(12, 12);
            this.gbcenario.Name = "gbcenario";
            this.gbcenario.Size = new System.Drawing.Size(440, 341);
            this.gbcenario.TabIndex = 4;
            this.gbcenario.TabStop = false;
            this.gbcenario.Text = "Definição de Cenários";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(252, 312);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtCodCen
            // 
            this.txtCodCen.Enabled = false;
            this.txtCodCen.Location = new System.Drawing.Point(121, 32);
            this.txtCodCen.Name = "txtCodCen";
            this.txtCodCen.Size = new System.Drawing.Size(282, 20);
            this.txtCodCen.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Código Cenário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(121, 268);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(282, 21);
            this.cboStatus.TabIndex = 5;
            // 
            // cboProj
            // 
            this.cboProj.FormattingEnabled = true;
            this.cboProj.Location = new System.Drawing.Point(121, 81);
            this.cboProj.Name = "cboProj";
            this.cboProj.Size = new System.Drawing.Size(282, 21);
            this.cboProj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projeto:";
            // 
            // btnCancelaCen
            // 
            this.btnCancelaCen.Location = new System.Drawing.Point(171, 312);
            this.btnCancelaCen.Name = "btnCancelaCen";
            this.btnCancelaCen.Size = new System.Drawing.Size(75, 23);
            this.btnCancelaCen.TabIndex = 4;
            this.btnCancelaCen.Text = "Cancelar";
            this.btnCancelaCen.UseVisualStyleBackColor = true;
            this.btnCancelaCen.Click += new System.EventHandler(this.btnCancelaCen_Click);
            // 
            // btnAvancaCen
            // 
            this.btnAvancaCen.Location = new System.Drawing.Point(333, 312);
            this.btnAvancaCen.Name = "btnAvancaCen";
            this.btnAvancaCen.Size = new System.Drawing.Size(70, 23);
            this.btnAvancaCen.TabIndex = 3;
            this.btnAvancaCen.Text = "Avançar";
            this.btnAvancaCen.UseVisualStyleBackColor = true;
            this.btnAvancaCen.Click += new System.EventHandler(this.btnAvancaCen_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(121, 180);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(282, 62);
            this.txtDesc.TabIndex = 2;
            // 
            // txtNomeCen
            // 
            this.txtNomeCen.Location = new System.Drawing.Point(121, 131);
            this.txtNomeCen.MaxLength = 50;
            this.txtNomeCen.Name = "txtNomeCen";
            this.txtNomeCen.Size = new System.Drawing.Size(282, 20);
            this.txtNomeCen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Cenário:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(90, 312);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmModelagemCenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 365);
            this.Controls.Add(this.gbcenario);
            this.Name = "frmModelagemCenario";
            this.Text = "frmModelagem";
            this.Load += new System.EventHandler(this.frmModelagemCenario_Load);
            this.gbcenario.ResumeLayout(false);
            this.gbcenario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbcenario;
        private System.Windows.Forms.Button btnCancelaCen;
        private System.Windows.Forms.Button btnAvancaCen;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNomeCen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtCodCen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpar;
    }
}