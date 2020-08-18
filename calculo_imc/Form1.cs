using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtImc.Text = "";
            txtPeso.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*declaração de variaveis
             * variavel recebe valro da textbox */
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            /* text box recebe conteudo da variavel imc= resultado do calculo
             * definição de utlilização de 2 casas decimais */
            txtImc.Text = imc.ToString("0.00");

            /* condiçoes de acordo com so resultados dos calculos (ifs)
             * serão exibidas mensagens,
             * configurações das messagebox (mensagens botoes icones)
             * varios ifs = varias condicoes */
            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você esta abaixo do peso", "Cálculo de IMC", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você esta com peso dentro da normalidade", "Cálculo de IMC", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você esta acima do peso", "Cálculo de IMC", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("ATENÇÃO: Você esta com Obesidade Grau I (leve)", "Cálculo de IMC", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("ATENÇÃO: Você esta com Obesidade Grau II (severa)", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("ATENÇÃO: Você esta com Obesidade Grau III (morbida)", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
