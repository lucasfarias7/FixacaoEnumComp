using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FixacaoEnumComp.Entities
{
    public class ItemPedido
    {
        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public Produto produto { get; set; }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public ItemPedido()
        {
        }

        /// <summary>
        /// Construtor com 3 argumentos
        /// </summary>
        /// <param name="qtd">Informe a quantidade de itens</param>
        /// <param name="preco">informe o preco</param>
        /// <param name="prod">informe o produto</param>
        public ItemPedido(int qtd, double preco, Produto prod)
        {
            this.Quantidade = qtd;
            this.Preco = preco;
            this.produto = prod;
        }

        public double Subtotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
           
            return "Nome do produto: "
                   + this.produto.Nome
                   + ", Preço: R$ "
                   + this.produto.preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", Quantidade: "
                   + this.Quantidade
                   + ", SubTotal R$: "
                   + Subtotal();
        }
    }
}
