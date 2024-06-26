using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orcamento_Pintura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(textBox1.Text);
                double largura = Convert.ToDouble(textBox2.Text);
                double precoPorMetroQuadrado = Convert.ToDouble(textBox3.Text);
                int numeroDeDemaos = Convert.ToInt32(textBox4.Text);

                if (altura <= 0 || largura <= 0 || precoPorMetroQuadrado <= 0 || numeroDeDemaos <= 0)
                {
                    MessageBox.Show("Por favor, insira valores maiores que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double areaTotal = altura * largura * numeroDeDemaos;

                double custoTotal = areaTotal * precoPorMetroQuadrado;

                label5.Text = "Resultado: R$ " + custoTotal.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFecharOrcamento_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            label5.Text = "Resultado: R$ 0,00";
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
