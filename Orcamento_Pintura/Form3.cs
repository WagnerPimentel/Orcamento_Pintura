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

namespace Orcamento_Pintura
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=bd_orcamento;password=;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_orcamentos", conn);

            DataTable dt = new DataTable();
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
     
    }
}
