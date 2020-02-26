using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoEnumComp.Entities.Enum;
using System.Globalization;

namespace FixacaoEnumComp.Entities
{
    public class Pedido
    {
        public DateTime MomentoPedido { get; set; }

        public StatusPedido Status { get; set; }

        public Cliente cliente { get; set; }

        public List<ItemPedido> itemPedidos { get; set; } = new List<ItemPedido>();

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Pedido()
        {                
        }

        /// <summary>
        /// Construtor com 1 argumento
        /// </summary>
        /// <param name="status">status do pedido</param>
        public Pedido(StatusPedido status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Construtor com 3 argumentos
        /// </summary>
        /// <param name="momentopedido">instante do pedido</param>
        /// <param name="statuspedido">status do pedido</param>
        /// <param name="client">informações do cliente</param>
        public Pedido(DateTime momentopedido, StatusPedido statuspedido, Cliente client)
        {
            this.MomentoPedido = momentopedido;
            this.Status = statuspedido;
            this.cliente = client;
        }

        /// <summary>
        /// Função para adicionar um item ao pedido
        /// </summary>
        /// <param name="item">informe o item</param>
        public void AddItem(ItemPedido item)
        {
            this.itemPedidos.Add(item);
        }

        /// <summary>
        /// função para remover um item do pedido
        /// </summary>
        /// <param name="item">informe o item</param>
        public void RemoveItem(ItemPedido item)
        {
            this.itemPedidos.Remove(item);
        }


        public double Total()
        {
            double Total = 0;

            foreach(ItemPedido item in itemPedidos)
            {
                Total += item.Subtotal();
            }

            return Total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + MomentoPedido.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + cliente.Nome);
            sb.AppendLine("Email Cliente: " + cliente.Email);
            sb.AppendLine("Order items:");
            foreach (ItemPedido item in itemPedidos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }

    }
}
