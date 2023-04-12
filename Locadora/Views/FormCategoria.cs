using Locadora.Context;
using Locadora.Models;
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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                var categoria = new Categoria { Nome = textBoxNomeCategoria.Text, ValorDia = float.Parse(textBoxValorCategoria.Text) };
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
            MessageBox.Show("Categoria cadastrada com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNomeCategoria.Text = "";
            textBoxValorCategoria.Text = "";
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-2EM4T0F\\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True";
            string sqlQuery = "SELECT * FROM Categorias";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
    }
    
}
