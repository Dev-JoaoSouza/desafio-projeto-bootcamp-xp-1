using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_projeto_bootcamp_xp_1.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("\n" + "Digite a placa do veículo para estacionar: ");
            string placaVeiculo = Console.ReadLine();

            this.veiculos.Add(placaVeiculo);

            Console.WriteLine("Veículo cadastrado com Sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.Write("\n" + "Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            if (placa != "" && this.veiculos.Contains(placa))
            {
                Console.Write("\n" + "Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                decimal horas = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();
                decimal valorTotal = this.precoInicial + (this.precoPorHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O Veiculo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente!" + "\n");
            }
        }

        public void ListarVeiculos()
        {
            if (this.veiculos.Count() > 0)
            {
                Console.WriteLine("\n" + "==============================");
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in this.veiculos)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n" + "==============================");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}