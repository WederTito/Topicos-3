using Locadora.Context;
using System;
using System.Windows.Forms;
using Locadora.Models;
using System.Linq;
using Locadora.Migrations;
using System.Runtime.Remoting.Contexts;
using System.Collections.Generic;

namespace Locadora
{
    public partial class FormLocacao : Form
    {
        private MeuContexto contexto;
        private List<Cliente> clientes;
        private List<Models.Carro> carros;
        private List<Models.Usuario> usuarios;

        public FormLocacao()
        {
            InitializeComponent();

            contexto = new MeuContexto();

            clientes = contexto.Clientes.ToList();
            carros = contexto.Carros.ToList();
            usuarios = contexto.Usuarios.ToList();

            // ComboBox Cliente
            comboBoxCliente.DataSource = clientes;
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.ValueMember = "Id";

            // ComboBox Carro
            comboBoxCarro.DataSource = carros;
            comboBoxCarro.DisplayMember = "Modelo";
            comboBoxCarro.ValueMember = "Id";

            // ComboBox Usuario
            comboBoxVendedor.DataSource = usuarios;
            comboBoxVendedor.DisplayMember = "Nome";
            comboBoxVendedor.ValueMember = "Id";


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var contexto = new MeuContexto())
            {
                var locacao = new Models.Locacao
                {
                    Cliente = comboBoxCliente.SelectedItem as Cliente,
                    Carro = comboBoxCarro.SelectedItem as Models.Carro,
                    Usuario = comboBoxVendedor.SelectedItem as Models.Usuario,
                    Retirada = dateTimePickerRetirada.Value,
                    Devolucao = dateTimePickerDevolucao.Value
                };

                if (!locacao.ValidarDatas())
                {
                    MessageBox.Show("A data de devolução não pode ser anterior à data de retirada.");
                    return;
                }

                contexto.Locacoes.Add(locacao);
                contexto.SaveChanges();
            }
            MessageBox.Show("Locação Realizada com sucesso! Bom proveito!");
            LimparCampos();
        }
        private void LimparCampos()
        {
            comboBoxCliente.SelectedIndex = -1;
            comboBoxCarro.SelectedIndex = -1;
            comboBoxVendedor.SelectedIndex = -1;
            dateTimePickerRetirada.Text = "";
            dateTimePickerDevolucao.Text = "";
        }
    }
}
