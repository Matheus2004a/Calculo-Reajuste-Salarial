using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_Reajuste : Form
    {
        public Form_Reajuste()
        {
            InitializeComponent();
        }

        private void btn_CalcularAjuste_Click_1(object sender, EventArgs e)
        {
            decimal salario_Mensal, valor_Reajuste, salarioComReajuste;

            if (text_SalMensal.Text == "")
            {
                MessageBox.Show("Valor do salário é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (text_ValorReajuste.Text == "")
            {
                MessageBox.Show("Valor do reajuste é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            salario_Mensal = Convert.ToDecimal(text_SalMensal.Text);
            valor_Reajuste = Convert.ToDecimal(text_ValorReajuste.Text);
            salarioComReajuste = (salario_Mensal * valor_Reajuste) / 100;

            MessageBox.Show("O valor do salário com reajuste é de: R$ " + string.Format("{0:n2}",salario_Mensal + salarioComReajuste));
        }

        private void text_SalMensal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_ValorReajuste.Focus();
            }
        }

        private void Form_Reajuste_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirma a saída da formulário?","Mensagem", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            text_SalMensal.Clear();
            text_ValorReajuste.Clear();
            text_SalMensal.Focus();
        }
    }
}
