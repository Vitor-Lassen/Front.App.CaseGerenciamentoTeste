namespace Front.App.CaseGerenciamentoTeste
{
    partial class CadastroUsuario
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
            this.txtboxNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtboxSobrenomeUsuario = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.comboxNivelAcesso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttCadUsuario = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttCancelaeSai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxNomeUsuario
            // 
            this.txtboxNomeUsuario.Location = new System.Drawing.Point(191, 49);
            this.txtboxNomeUsuario.Name = "txtboxNomeUsuario";
            this.txtboxNomeUsuario.Size = new System.Drawing.Size(218, 20);
            this.txtboxNomeUsuario.TabIndex = 0;
            // 
            // txtboxSobrenomeUsuario
            // 
            this.txtboxSobrenomeUsuario.Location = new System.Drawing.Point(191, 94);
            this.txtboxSobrenomeUsuario.Name = "txtboxSobrenomeUsuario";
            this.txtboxSobrenomeUsuario.Size = new System.Drawing.Size(218, 20);
            this.txtboxSobrenomeUsuario.TabIndex = 1;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(191, 144);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(218, 20);
            this.txtboxEmail.TabIndex = 2;
            // 
            // comboxNivelAcesso
            // 
            this.comboxNivelAcesso.FormattingEnabled = true;
            this.comboxNivelAcesso.Location = new System.Drawing.Point(191, 193);
            this.comboxNivelAcesso.Name = "comboxNivelAcesso";
            this.comboxNivelAcesso.Size = new System.Drawing.Size(218, 21);
            this.comboxNivelAcesso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nível de Acesso:";
            // 
            // bttCadUsuario
            // 
            this.bttCadUsuario.Location = new System.Drawing.Point(334, 262);
            this.bttCadUsuario.Name = "bttCadUsuario";
            this.bttCadUsuario.Size = new System.Drawing.Size(75, 23);
            this.bttCadUsuario.TabIndex = 8;
            this.bttCadUsuario.Text = "Cadastar";
            this.bttCadUsuario.UseVisualStyleBackColor = true;
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(241, 262);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpar.TabIndex = 9;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            // 
            // bttCancelaeSai
            // 
            this.bttCancelaeSai.Location = new System.Drawing.Point(147, 262);
            this.bttCancelaeSai.Name = "bttCancelaeSai";
            this.bttCancelaeSai.Size = new System.Drawing.Size(75, 23);
            this.bttCancelaeSai.TabIndex = 10;
            this.bttCancelaeSai.Text = "Cancelar";
            this.bttCancelaeSai.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(494, 321);
            this.Controls.Add(this.bttCancelaeSai);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttCadUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxNivelAcesso);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxSobrenomeUsuario);
            this.Controls.Add(this.txtboxNomeUsuario);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNomeUsuario;
        private System.Windows.Forms.TextBox txtboxSobrenomeUsuario;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.ComboBox comboxNivelAcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttCadUsuario;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button bttCancelaeSai;
    }
}