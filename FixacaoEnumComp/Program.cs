﻿using FixacaoEnumComp.Entities;
using FixacaoEnumComp.Entities.Enum;
using System;
using System.ServiceProcess;
using System.Globalization;

namespace MyWindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);

            Console.WriteLine("Entre com os dados do cliente");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime dataniver = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Cliente c1 = new Cliente(nome, email, dataniver);
            Console.WriteLine("Entre com dados do pedido: ");
            Console.Write("Status do pedido: ");
            StatusPedido status = (StatusPedido)System.Enum.Parse(typeof(StatusPedido), Console.ReadLine());
            Console.WriteLine();

            Pedido pedido = new Pedido(DateTime.Now, status, c1);

            Console.WriteLine("Quantos itens para este pedido ? ");
            int n = int.Parse(Console.ReadLine());

            ItemPedido ip = null;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Entre com os dados do produto: ");
                Console.WriteLine("#" + i + " pedido: ");
                Console.Write("Nome: ");
                string nomeprod = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                Produto p1 = new Produto(nomeprod, preco);

                ip = new ItemPedido(qtd, preco, p1);

                pedido.AddItem(ip);

            }

            Console.WriteLine();

            Console.WriteLine(pedido);


            Console.ReadKey();
        }
    }
}
