using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Orcamento_Pintura
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void btnEfetuarCadastro_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=bd_orcamento;password=;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_orcamentos (nome_cliente, endereco, telefone, servicos, materiais, valor_mao_de_obra, valor_materiais, tempo_previsto) VALUES (@nome_cliente, @endereco, @telefone, @servicos, @materiais, @valor_mao_de_obra, @valor_materiais, @tempo_previsto)", conn);


            cmd.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@servicos", txtServicos.Text);
            cmd.Parameters.AddWithValue("@materiais", txtMateriais.Text);
            cmd.Parameters.AddWithValue("@valor_mao_de_obra", "R$ " + txtMaoDeObra.Text);
            cmd.Parameters.AddWithValue("@valor_materiais", "R$ " +  txtValorDosMateriais.Text);
            cmd.Parameters.AddWithValue("@tempo_previsto", txtTempoPrevisto.Text);



            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();


            if (rowsAffected > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados. ");
            }

            txtNomeCliente.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtServicos.Text = "";
            txtMateriais.Text = "";
            txtMaoDeObra.Text = "";
            txtValorDosMateriais.Text = "";
            txtTempoPrevisto.Text = "";

        }
    }
}
