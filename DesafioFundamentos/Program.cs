using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = ObterPreco("Digite o preço inicial:");
decimal precoPorHora = ObterPreco("Agora digite o preço por hora:");

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    exibirMenu = ExibirMenu(estacionamento);
}

Console.WriteLine("O programa se encerrou");


static decimal ObterPreco(string mensagem)
{
    decimal preco;
    Console.WriteLine(mensagem);

    while (!decimal.TryParse(Console.ReadLine(), out preco) || preco < 0)
    {
        Console.WriteLine("Preço inválido. Por favor, digite um valor numérico válido maior ou igual a zero:");
    }

    return preco;
}

static bool ExibirMenu(Estacionamento estacionamento)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            return false;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey();
    return true;
}

