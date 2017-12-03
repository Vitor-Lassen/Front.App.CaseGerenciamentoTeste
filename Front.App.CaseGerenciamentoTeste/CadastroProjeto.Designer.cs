namespace Front.App.CaseGerenciamentoTeste
{
    partial class CadastroProjeto
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
            this.txtboxNomeProj = new System.Windows.Forms.TextBox();
            this.txtboxObjetivo = new System.Windows.Forms.TextBox();
            this.comboxSisEnvolvi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttCadastrarProj = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttCancelaeSai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxNomeProj
            // 
            this.txtboxNomeProj.Location = new System.Drawing.Point(209, 43);
            this.txtboxNomeProj.Name = "txtboxNomeProj";
            this.txtboxNomeProj.Size = new System.Drawing.Size(254, 20);
            this.txtboxNomeProj.TabIndex = 0;
            // 
            // txtboxObjetivo
            // 
            this.txtboxObjetivo.Location = new System.Drawing.Point(209, 82);
            this.txtboxObjetivo.Multiline = true;
            this.txtboxObjetivo.Name = "txtboxObjetivo";
            this.txtboxObjetivo.Size = new System.Drawing.Size(254, 67);
            this.txtboxObjetivo.TabIndex = 1;
            // 
            // comboxSisEnvolvi
            // 
            this.comboxSisEnvolvi.FormattingEnabled = true;
            this.comboxSisEnvolvi.Location = new System.Drawing.Point(209, 177);
            this.comboxSisEnvolvi.Name = "comboxSisEnvolvi";
            this.comboxSisEnvolvi.Size = new System.Drawing.Size(254, 21);
            this.comboxSisEnvolvi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Objetivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sistemas Envolvidos:";
            // 
            // bttCadastrarProj
            // 
            this.bttCadastrarProj.Location = new System.Drawing.Point(388, 248);
            this.bttCadastrarProj.Name = "bttCadastrarProj";
            this.bttCadastrarProj.Size = new System.Drawing.Size(75, 23);
            this.bttCadastrarProj.TabIndex = 6;
            this.bttCadastrarProj.Text = "Cadastrar";
            this.bttCadastrarProj.UseVisualStyleBackColor = true;
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(294, 248);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpar.TabIndex = 7;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            // 
            // bttCancelaeSai
            // 
            this.bttCancelaeSai.Location = new System.Drawing.Point(198, 248);
            this.bttCancelaeSai.Name = "bttCancelaeSai";
            this.bttCancelaeSai.Size = new System.Drawing.Size(75, 23);
            this.bttCancelaeSai.TabIndex = 8;
            this.bttCancelaeSai.Text = "Cancelar";
            this.bttCancelaeSai.UseVisualStyleBackColor = true;
            // 
            // CadastroProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(529, 320);
            this.Controls.Add(this.bttCancelaeSai);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttCadastrarProj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxSisEnvolvi);
            this.Controls.Add(this.txtboxObjetivo);
            this.Controls.Add(this.txtboxNomeProj);
            this.Name = "CadastroProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNomeProj;
        private System.Windows.Forms.TextBox txtboxObjetivo;
        private System.Windows.Forms.ComboBox comboxSisEnvolvi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttCadastrarProj;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button bttCancelaeSai;
    }
}