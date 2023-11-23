using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<Carros> veiculos = new List<Carros>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Carros carro = new Carros();

            Console.WriteLine("Digite o nome do veículo para estacionar:");
            carro.NomeCarro = Console.ReadLine();

            Console.WriteLine("Digite a cor do veículo para estacionar:");
            carro.CorCarro = Console.ReadLine();

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            carro.Placa = Console.ReadLine();

            veiculos.Add(carro);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(veiculos.Find(x => x.Placa.ToUpper() == placa.ToUpper()));

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                for (int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"Nº {contador + 1} - Carro: {veiculos[contador].NomeCarro} - Cor: {veiculos[contador].CorCarro} - Placa: {veiculos[contador].Placa}");
                }
            }
            else
            {
                Console.WriteLine($"Não há veículos estacionados.");
            }
        }
    }
}

