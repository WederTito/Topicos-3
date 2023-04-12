using Locadora.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Models;
using System.Data.SqlClient;

namespace Locadora
{
    public partial class FormCarro : Form
    {
        private MeuContexto contexto;
        private List<Marca> marcas;
        private List<Categoria> categorias;

        public FormCarro()
        {
            InitializeComponent();

            contexto = new MeuContexto();

            marcas = contexto.Marcas.ToList();
                        
            comboBoxMarca.DataSource = marcas;
            comboBoxMarca.DisplayMember = "Nome";
            comboBoxMarca.ValueMember = "Id"; 

            
            categorias = contexto.Categorias.ToList();
                        
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "Nome";
            comboBoxCategoria.ValueMember = "Id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var carro = new Carro
            {
                Marca = comboBoxMarca.SelectedItem as Marca,
                Modelo = textBoxModelo.Text,
                Categoria = comboBoxCategoria.SelectedItem as Categoria,
                Cor = textBoxCor.Text,
                Chassi = textBoxChassi.Text,
                Placa = textBoxPlaca.Text
            };

            contexto.Carros.Add(carro);
            contexto.SaveChanges();

            LimparCampos();

            MessageBox.Show("Carro cadastrado com sucesso!");
        }

        private void LimparCampos()
        {
            comboBoxMarca.SelectedIndex = -1;
            textBoxModelo.Text = "";
            comboBoxCategoria.SelectedIndex = -1;
            textBoxCor.Text = "";
            textBoxChassi.Text = "";
            textBoxPlaca.Text = "";
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-2EM4T0F\\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True";
            string sqlQuery = "SELECT * FROM Carroes";

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
