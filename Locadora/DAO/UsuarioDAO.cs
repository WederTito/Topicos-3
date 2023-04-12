using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.DAO
{
    internal class UsuarioDAO
    {
        private string connectionString = "Data Source=DESKTOP-2EM4T0F\\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True";

        public Usuario ObterUsuarioPorEmailSenha(string email, string senha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Usuarios WHERE Email = @Email AND Senha = @Senha", connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Email = Convert.ToString(reader.GetInt32(0));
                    usuario.Senha = Convert.ToString(reader.GetString(1));
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
        }
    }

}
