using BenchmarkDotNet.Running;
using ProgDistrib.QuartaQuestao;

// const long tamanhoVetor = int.MaxValue/5;
//
// var vetor = new int[tamanhoVetor];
// var random = new Random();
//
// // Populando Vetor
// for (long i = 0; i < tamanhoVetor; i++)
//     vetor[i] = random.Next(0, 10);
//
// ThreadPool.GetAvailableThreads(out var workerThreads, out _);
// workerThreads = workerThreads / 2; // Vou usar apenas metade porque sim.
//
// var qtdSomaPorThread = tamanhoVetor / workerThreads;
// var tasks = new List<Task>();
// long alvoSoma = 0;
// for (var i = 0; i < workerThreads; i++)
// {
//     var inicio = i * qtdSomaPorThread;
//     var fim = i == workerThreads - 1 ? tamanhoVetor : (i + 1) * qtdSomaPorThread;
//     tasks.Add(Task.Run(() => SomaThread.Somar(vetor, inicio, fim, ref alvoSoma)));
// }
//
// await Task.WhenAll(tasks);
//
// Console.WriteLine($"O resultado da soma rápida é: {alvoSoma}");
// var somaLerda = vetor.Sum();
// Console.WriteLine($"O resultado da soma lerda é: {somaLerda}");

var summary = BenchmarkRunner.Run<SomaBenchmark>();