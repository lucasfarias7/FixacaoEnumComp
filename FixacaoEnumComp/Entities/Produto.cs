using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoEnumComp.Entities
{
    public class Produto
    {
        public string Nome { get; set; }

        public double preco { get; set; }


        public Produto()
        {
        }

        /// <summary>
        /// Construtor com 2 argumentos
        /// </summary>
        /// <param name="nome">informe o nome do produto</param>
        /// <param name="preco">informe o preco do produto</param>
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.preco = preco;
        }
    }
}
