using Locadora.DAO;
using Locadora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxLogin.Text;
            string senha = textBoxSenha.Text;

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario usuario = usuarioDAO.ObterUsuarioPorEmailSenha(email, senha);

            if (usuario != null)
            {
                // Login bem-sucedido
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
            }
            else
            {
                // Login falhou
                MessageBox.Show("Usuario ou Senha incorretos!");
            }

            
        }
    }
}
