using System.Diagnostics;
using ProgDistrib.QuartaQuestao;

const long tamanhoVetor = int.MaxValue/5;

var vetor = new int[tamanhoVetor];
var random = new Random();

// Populando Vetor
for (long i = 0; i < tamanhoVetor; i++)
    vetor[i] = random.Next(0, 10);

ThreadPool.GetAvailableThreads(out var workerThreads, out _);
workerThreads = workerThreads / 2; // Vou usar apenas metade porque sim.

var qtdSomaPorThread = tamanhoVetor / workerThreads;
var tasks = new List<Task<long>>();
var stopWatch = new Stopwatch();
stopWatch.Start();
for (var i = 0; i < workerThreads; i++)
{
    var inicio = i * qtdSomaPorThread;
    var fim = i == workerThreads - 1 ? tamanhoVetor - 1 : (i + 1) * qtdSomaPorThread - 1;
    tasks.Add(Task.Run(() => SomaThread.Somar(vetor, inicio, fim)));
}
var resultados = await tasks.WaitAllWithResults();
stopWatch.Stop();

Console.WriteLine($"O resultado da soma rápida é: {resultados.Sum()} e demorou {stopWatch.Elapsed:c}");

stopWatch.Restart();
var somaLerda = vetor.Sum();
stopWatch.Stop();
Console.WriteLine($"O resultado da soma lerda é: {somaLerda} e demorou {stopWatch.Elapsed:c}");