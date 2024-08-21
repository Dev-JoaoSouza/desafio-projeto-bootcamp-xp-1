// Sistema para um estacionamento
using desafio_projeto_bootcamp_xp_1.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Write("\n"+"Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();

Console.Write("Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("---Menu---");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("Digite a sua opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            Console.WriteLine("Encerrar!");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("\n" + "Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("\n"+"O programa se encerrou!");
