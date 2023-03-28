using ProgDistrib.TerceiraQuestao;

var tarefas = new List<Task<string>>
{
    Task.Run(Balcao.GetPipoca),
    Task.Run(Balcao.GetRefrigerante)
};
Console.WriteLine("[STATUS] Pedido realizado com sucesso! Aguardando preparação...");
var results = await tarefas.WaitAllWithResults(); // Implementei esse método para esperar todas e pegar seus resultados.
foreach (var result in results)
{
    Console.WriteLine($"[STATUS] {result}");
}

Console.WriteLine("[STATUS] Pedido entregue!");