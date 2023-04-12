using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locadora.Models;

namespace Locadora.Context
{
    internal class MeuContexto : DbContext
    {
        public MeuContexto() : base("Data Source=DESKTOP-2EM4T0F\\SQLEXPRESS;Initial Catalog=locadora;Integrated Security=True")
        {
        }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
    }

}
