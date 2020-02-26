using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoEnumComp.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNiver { get; set; }


        public Cliente()
        {
        }

        /// <summary>
        /// Construtor com 3 argumentos
        /// </summary>
        /// <param name="nome">informe o nome do cliente</param>
        /// <param name="email">informe o email do cliente</param>
        /// <param name="dataNiver">informe a data de nascimento do cliente</param>
        public Cliente(string nome, string email, DateTime dataNiver)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataNiver = dataNiver;
        }
    }
}
