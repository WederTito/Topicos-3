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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                var marca = new Marca { Nome = textBoxNomeMarca.Text, Sigla = textBoxSiglaMarca.Text };
                contexto.Marcas.Add(marca);
                contexto.SaveChanges();
            }
            MessageBox.Show("Marca cadastrada com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNomeMarca.Text = "";
            textBoxSiglaMarca.Text = "";
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-2EM4T0F\\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True";
            string sqlQuery = "SELECT * FROM Marcas";

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
