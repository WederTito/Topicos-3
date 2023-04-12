using Locadora.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class FormMain : Form
    {
        private MeuContexto contexto;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnIniciarLocacao_Click(object sender, EventArgs e)
        {
            FormLocacao formLocacao = new FormLocacao();
            formLocacao.ShowDialog();
        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            FormCarro formCarro = new FormCarro();
            formCarro.ShowDialog();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria();
            formCategoria.ShowDialog();
        }

        private void buttonCadastrarMarca_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca();
            formMarca.ShowDialog();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-2EM4T0F\\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True";
            string sqlQuery = "SELECT * FROM Locacaos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
