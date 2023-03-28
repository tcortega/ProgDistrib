using ProgDistrib.PrimeiraQuestao;
using ProgDistrib.PrimeiraQuestao.Deposito;
using ProgDistrib.PrimeiraQuestao.Saque;
using ProgDistrib.PrimeiraQuestao.Services;

var conta = Conta.Criar(1, "Tarcisio", 1000);

Console.WriteLine($"Saldo inicial: {conta.Saldo}");
var servicos = new List<IServico> { new AGastadora(), new AEconomica(), new AEsperta(), new APatrocinadora()};
var tasks = servicos.Select(service => Task.Run(service.Start)).ToList();
Console.ReadLine();

