using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Front.App.CaseGerenciamentoTeste.Utilities
{
    class Limpar
    {
        
        public void limparRDB(GroupBox g)
        {
            for (int i = 0; i < g.Controls.Count; i++)  // LAÇO DE REPETIÇÃO QUE VERIFICA A QUANTIDADE DE CONTROLES NO FORM
            {
                if (g.Controls[i] is RadioButton)
                {
                    ((RadioButton)g.Controls[i]).Checked = false;
                }
            }
        }
        public void limparDS(DataSet ds)
        {
          for(int i=0; i < ds.Tables.Count; i++)
          {
              while(  ds.Tables[i].Rows.Count >0)
              {
                  ds.Tables[i].Rows.RemoveAt(0);
              }
          }
        }
        public void limparDGV(DataGridView dgv)
        {
            int i = 0;
            while( i < dgv.Rows.Count)
            {
                dgv.Rows.RemoveAt(0);

            }
        }
        public void limpar(Panel p) // CRIAÇÃO DO MÉTODO, USANDO O PARÂMETRO f QUE REPRESENTA O FORM 
        {
            for (int i = 0; i < p.Controls.Count; i++)  // LAÇO DE REPETIÇÃO QUE VERIFICA A QUANTIDADE DE CONTROLES NO FORM
            {
                if ((p.Controls[i] is TextBox) || (p.Controls[i] is MaskedTextBox)) // VERIFICA SE O CONTROLE É DO TIPO TextBox
                {
                   p.Controls[i].Text = "";
                }
                
                else if (p.Controls[i] is ComboBox)
                {
                    ((ComboBox)p.Controls[i]).Text = "";
                    ((ComboBox)p.Controls[i]).SelectedIndex = -1;
                }
                
                else if (p.Controls[i] is DataGridView)
                {
                    while (((DataGridView)p.Controls[i]).Rows.Count > 0)
                    {
                        ((DataGridView)p.Controls[i]).Rows.RemoveAt(0);
                    }
                }
                else if (p.Controls[i] is RadioButton)
                {
                    ((RadioButton)p.Controls[i]).Checked = false;
                }
                else if (p.Controls[i] is RichTextBox)
                {
                    ((RichTextBox)p.Controls[i]).Clear();
                }
                else if (p.Controls[i] is CheckBox)
                {
                    ((CheckBox)p.Controls[i]).Checked = false;
                }
            }
        }
        public void limpar(Form f) // CRIAÇÃO DO MÉTODO, USANDO O PARÂMETRO f QUE REPRESENTA O FORM 
        {
            for (int i = 0; i < f.Controls.Count; i++)  // LAÇO DE REPETIÇÃO QUE VERIFICA A QUANTIDADE DE CONTROLES NO FORM
            {
                if ((f.Controls[i] is TextBox) || (f.Controls[i] is MaskedTextBox)) // VERIFICA SE O CONTROLE É DO TIPO TextBox
                {
                    f.Controls[i].Text = "";
                }

                else if (f.Controls[i] is ComboBox)
                {
                    ((ComboBox)f.Controls[i]).Text = "";
                    ((ComboBox)f.Controls[i]).SelectedIndex = -1;
                }

                else if (f.Controls[i] is DataGridView)
                {
                    while (((DataGridView)f.Controls[i]).Rows.Count > 0)
                    {
                        ((DataGridView)f.Controls[i]).Rows.RemoveAt(0);
                    }
                }
                else if (f.Controls[i] is RadioButton)
                {
                    ((RadioButton)f.Controls[i]).Checked = false;
                }
                else if (f.Controls[i] is RichTextBox)
                {
                    ((RichTextBox)f.Controls[i]).Clear();
                }
                else if(f.Controls[i] is CheckBox)
                {
                    ((CheckBox)f.Controls[i]).Checked = false;
                }
            }
        }
        public void limpar(GroupBox g) // CRIAÇÃO DO MÉTODO, USANDO O PARÂMETRO f QUE REPRESENTA O FORM 
        {
            for (int i = 0; i < g.Controls.Count; i++)  // LAÇO DE REPETIÇÃO QUE VERIFICA A QUANTIDADE DE CONTROLES NO FORM
            {
                if ((g.Controls[i] is TextBox) || (g.Controls[i] is MaskedTextBox)) // VERIFICA SE O CONTROLE É DO TIPO TextBox
                {
                    g.Controls[i].Text = "";
                }

                else if (g.Controls[i] is ComboBox)
                {
                    ((ComboBox)g.Controls[i]).Text = "";
                    ((ComboBox)g.Controls[i]).SelectedIndex = -1;
                }

                else if (g.Controls[i] is DataGridView)
                {
                    while (((DataGridView)g.Controls[i]).Rows.Count > 0)
                    {
                        ((DataGridView)g.Controls[i]).Rows.RemoveAt(0);
                    }
                }
                else if (g.Controls[i] is RadioButton)
                {
                    ((RadioButton)g.Controls[i]).Checked = false;
                }
                else if (g.Controls[i] is RichTextBox)
                {
                    ((RichTextBox)g.Controls[i]).Clear();
                }
                else if(g.Controls[i] is CheckBox)
                {
                    ((CheckBox)g.Controls[i]).Checked = false;
                }
            }
        }
    }
}
