using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Models
{
    internal class Locacao
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Carro Carro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Retirada { get; set; }
        public DateTime Devolucao { get; set; }

        public bool ValidarDatas()
        {
            if (Devolucao < Retirada)
            {
                return false;
            }
            return true;
        }
    }
}
