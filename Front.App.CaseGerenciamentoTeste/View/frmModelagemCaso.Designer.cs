namespace Front.App.CaseGerenciamentoTeste.View
{
    partial class frmModelagemCaso
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
            this.gbcaso = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCodCen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodCaso = new System.Windows.Forms.TextBox();
            this.btnConcluiCen = new System.Windows.Forms.Button();
            this.btnAdicionaCaso = new System.Windows.Forms.Button();
            this.txtMassaDado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultEsp = new System.Windows.Forms.TextBox();
            this.txtPreCond = new System.Windows.Forms.TextBox();
            this.txtNomeCaso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbcaso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcaso
            // 
            this.gbcaso.Controls.Add(this.label3);
            this.gbcaso.Controls.Add(this.cboStatus);
            this.gbcaso.Controls.Add(this.btnCancelar);
            this.gbcaso.Controls.Add(this.btnConsultar);
            this.gbcaso.Controls.Add(this.txtCodCen);
            this.gbcaso.Controls.Add(this.label2);
            this.gbcaso.Controls.Add(this.label1);
            this.gbcaso.Controls.Add(this.btnLimpar);
            this.gbcaso.Controls.Add(this.txtCodCaso);
            this.gbcaso.Controls.Add(this.btnConcluiCen);
            this.gbcaso.Controls.Add(this.btnAdicionaCaso);
            this.gbcaso.Controls.Add(this.txtMassaDado);
            this.gbcaso.Controls.Add(this.label7);
            this.gbcaso.Controls.Add(this.txtResultEsp);
            this.gbcaso.Controls.Add(this.txtPreCond);
            this.gbcaso.Controls.Add(this.txtNomeCaso);
            this.gbcaso.Controls.Add(this.label6);
            this.gbcaso.Controls.Add(this.label5);
            this.gbcaso.Controls.Add(this.label4);
            this.gbcaso.Location = new System.Drawing.Point(12, 12);
            this.gbcaso.Name = "gbcaso";
            this.gbcaso.Size = new System.Drawing.Size(746, 462);
            this.gbcaso.TabIndex = 6;
            this.gbcaso.TabStop = false;
            this.gbcaso.Text = "Definição de Casos:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(336, 433);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 23);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtCodCen
            // 
            this.txtCodCen.Enabled = false;
            this.txtCodCen.Location = new System.Drawing.Point(336, 28);
            this.txtCodCen.Name = "txtCodCen";
            this.txtCodCen.Size = new System.Drawing.Size(116, 20);
            this.txtCodCen.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código do Cenário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID do Caso:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(437, 433);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCodCaso
            // 
            this.txtCodCaso.Enabled = false;
            this.txtCodCaso.Location = new System.Drawing.Point(124, 28);
            this.txtCodCaso.MaxLength = 4;
            this.txtCodCaso.Name = "txtCodCaso";
            this.txtCodCaso.Size = new System.Drawing.Size(90, 20);
            this.txtCodCaso.TabIndex = 10;
            // 
            // btnConcluiCen
            // 
            this.btnConcluiCen.Location = new System.Drawing.Point(538, 433);
            this.btnConcluiCen.Name = "btnConcluiCen";
            this.btnConcluiCen.Size = new System.Drawing.Size(95, 23);
            this.btnConcluiCen.TabIndex = 6;
            this.btnConcluiCen.Text = "Concluir";
            this.btnConcluiCen.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaCaso
            // 
            this.btnAdicionaCaso.Location = new System.Drawing.Point(639, 433);
            this.btnAdicionaCaso.Name = "btnAdicionaCaso";
            this.btnAdicionaCaso.Size = new System.Drawing.Size(95, 23);
            this.btnAdicionaCaso.TabIndex = 5;
            this.btnAdicionaCaso.Text = "Adicionar";
            this.btnAdicionaCaso.UseVisualStyleBackColor = true;
            this.btnAdicionaCaso.Click += new System.EventHandler(this.btnAdicionaCaso_Click);
            // 
            // txtMassaDado
            // 
            this.txtMassaDado.Location = new System.Drawing.Point(124, 253);
            this.txtMassaDado.MaxLength = 200;
            this.txtMassaDado.Multiline = true;
            this.txtMassaDado.Name = "txtMassaDado";
            this.txtMassaDado.Size = new System.Drawing.Size(610, 60);
            this.txtMassaDado.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Massa de Dados:";
            // 
            // txtResultEsp
            // 
            this.txtResultEsp.Location = new System.Drawing.Point(124, 349);
            this.txtResultEsp.MaxLength = 200;
            this.txtResultEsp.Multiline = true;
            this.txtResultEsp.Name = "txtResultEsp";
            this.txtResultEsp.Size = new System.Drawing.Size(610, 60);
            this.txtResultEsp.TabIndex = 4;
            // 
            // txtPreCond
            // 
            this.txtPreCond.Location = new System.Drawing.Point(124, 150);
            this.txtPreCond.MaxLength = 200;
            this.txtPreCond.Multiline = true;
            this.txtPreCond.Name = "txtPreCond";
            this.txtPreCond.Size = new System.Drawing.Size(610, 60);
            this.txtPreCond.TabIndex = 2;
            // 
            // txtNomeCaso
            // 
            this.txtNomeCaso.Location = new System.Drawing.Point(124, 84);
            this.txtNomeCaso.MaxLength = 50;
            this.txtNomeCaso.Name = "txtNomeCaso";
            this.txtNomeCaso.Size = new System.Drawing.Size(610, 20);
            this.txtNomeCaso.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resutado Esperado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pré Condições:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome do Caso:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(504, 27);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(230, 21);
            this.cboStatus.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status:";
            // 
            // frmModelagemCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(775, 486);
            this.Controls.Add(this.gbcaso);
            this.Name = "frmModelagemCaso";
            this.Text = "frmModelagem2";
            this.Load += new System.EventHandler(this.frmModelagemCaso_Load);
            this.gbcaso.ResumeLayout(false);
            this.gbcaso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcaso;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCodCen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCodCaso;
        private System.Windows.Forms.Button btnConcluiCen;
        private System.Windows.Forms.Button btnAdicionaCaso;
        private System.Windows.Forms.TextBox txtMassaDado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResultEsp;
        private System.Windows.Forms.TextBox txtPreCond;
        private System.Windows.Forms.TextBox txtNomeCaso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}