namespace DesafioFundamentos.Models;
    public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(placa))
        {
            Console.WriteLine("Placa inválida. Tente novamente.");
            return;
        }

        veiculos.Add(placa);
        Console.WriteLine($"Veículo {placa} adicionado com sucesso.");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine()?.Trim();

        if (!veiculos.Contains(placa, StringComparer.OrdinalIgnoreCase))
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            return;
        }

        int horas = LerHorasEstacionadas();
        decimal valorTotal = CalcularValorTotal(horas);
        veiculos.Remove(placa);

        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var item in veiculos)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }

    private int LerHorasEstacionadas()
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        int horas;

        while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido de horas.");
        }

        return horas;
    }

    private decimal CalcularValorTotal(int horas)
    {
        return precoInicial + (precoPorHora * horas);
    }
}