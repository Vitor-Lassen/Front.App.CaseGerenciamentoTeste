namespace Front.App.CaseGerenciamentoTeste
{
    partial class PrimeiroLogin
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
            this.txtboxNovaSenha = new System.Windows.Forms.TextBox();
            this.txtboxConfirmaSenha = new System.Windows.Forms.TextBox();
            this.bttConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxNovaSenha
            // 
            this.txtboxNovaSenha.Location = new System.Drawing.Point(149, 28);
            this.txtboxNovaSenha.Name = "txtboxNovaSenha";
            this.txtboxNovaSenha.Size = new System.Drawing.Size(131, 20);
            this.txtboxNovaSenha.TabIndex = 0;
            // 
            // txtboxConfirmaSenha
            // 
            this.txtboxConfirmaSenha.Location = new System.Drawing.Point(149, 67);
            this.txtboxConfirmaSenha.Name = "txtboxConfirmaSenha";
            this.txtboxConfirmaSenha.Size = new System.Drawing.Size(131, 20);
            this.txtboxConfirmaSenha.TabIndex = 1;
            // 
            // bttConfirmar
            // 
            this.bttConfirmar.Location = new System.Drawing.Point(205, 119);
            this.bttConfirmar.Name = "bttConfirmar";
            this.bttConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bttConfirmar.TabIndex = 2;
            this.bttConfirmar.Text = "Confirmar";
            this.bttConfirmar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nova Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirmar Senha:";
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(124, 119);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpar.TabIndex = 5;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            // 
            // PrimeiroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(344, 171);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttConfirmar);
            this.Controls.Add(this.txtboxConfirmaSenha);
            this.Controls.Add(this.txtboxNovaSenha);
            this.Name = "PrimeiroLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNovaSenha;
        private System.Windows.Forms.TextBox txtboxConfirmaSenha;
        private System.Windows.Forms.Button bttConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttLimpar;
    }
}