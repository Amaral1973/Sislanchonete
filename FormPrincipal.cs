using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisLanchonete
{
    public partial class FormPrincipal : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True");

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True";
                String query = "SELECT * FROM Usuario";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Conectado ao Banco de Dados!", "Teste de Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            formVenda.Show();
        }

        private void pbClientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void pbUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
        }

        private void pbProduto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.Show();
        }

        private void pbVendas_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            formVenda.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbLanchoneteDataSet.ProdutosVendidos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosVendidosTableAdapter.Fill(this.dbLanchoneteDataSet.ProdutosVendidos);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NumeroProdutos", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                lblResultNumeroProdutos.Text = rd["quantidade"].ToString();
                rd.Close();
            }

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM MediaPrecos", con);
            cmd2.CommandType = CommandType.Text;
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
            {
                lblResultMediaPrecos.Text = "R$ " + rd2["media"].ToString();
                rd2.Close();
            }
            con.Close();
        }
    }
}
