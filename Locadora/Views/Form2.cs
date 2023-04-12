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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            foreach (var perfil in Enum.GetValues(typeof(Perfil)))
            {
                comboBoxPerfil.Items.Add(perfil);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            using (var contexto = new MeuContexto())
            {
                var usuario = new Usuario { Nome = textBoxNomeCompleto.Text, Cpf = textBoxCpf.Text, Cnh = textBoxCnh.Text,
                Email = textBoxEmail.Text, Senha = textBoxSenha.Text, ConfirmarSenha = textBoxConfirmarSenha.Text,
                Perfil = (Perfil)Enum.Parse(typeof(Perfil), comboBoxPerfil.SelectedItem.ToString())};
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
            }
            MessageBox.Show("Usuario cadastrado com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNomeCompleto.Text = "";
            textBoxCpf.Text = "";
            textBoxCnh.Text = "";
            textBoxEmail.Text = "";
            textBoxSenha.Text = "";
            textBoxConfirmarSenha.Text = "";
            comboBoxPerfil.Text = "";

        }

        private void Listar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-2EM4T0F\\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True";
            string sqlQuery = "SELECT * FROM Usuarios";

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
