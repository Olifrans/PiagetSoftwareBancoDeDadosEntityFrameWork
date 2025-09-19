using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusines
{
    class Produto : Base
    {
        public string? NomeDoProduto { get; set; }
        public string? DescricaoDoProduto { get; set; }
        public string? CodigoDoProduto { get; set; }
        public decimal PrecoDoProduto { get; set; }
    }
}
