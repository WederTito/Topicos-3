using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Models
{
    internal class Carro
    {
        public int Id { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public Categoria Categoria { get; set; }
        public string Cor { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
    }
}
