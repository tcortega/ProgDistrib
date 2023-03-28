using BenchmarkDotNet.Attributes;

namespace ProgDistrib.QuartaQuestao;

public class SomaBenchmark
{
    private const long TamanhoVetor = int.MaxValue / 5;
    private int[] _vetor = null!;
    
    [GlobalSetup]
    public void Setup()
    {
        _vetor = new int[TamanhoVetor];
        var random = new Random();

        for (long i = 0; i < TamanhoVetor; i++)
        {
            _vetor[i] = random.Next(0, 10);
        }
    }
    
    [Benchmark]
    public long SomaRapida()
    {
        ThreadPool.GetAvailableThreads(out var workerThreads, out _);
        workerThreads = workerThreads / 2;

        var qtdSomaPorThread = TamanhoVetor / workerThreads;
        var tasks = new List<Task>();
        long alvoSoma = 0;
        for (var i = 0; i < workerThreads; i++)
        {
            var inicio = i * qtdSomaPorThread;
            var fim = i == workerThreads - 1 ? TamanhoVetor : (i + 1) * qtdSomaPorThread;
            tasks.Add(Task.Run(() => SomaThread.Somar(_vetor, inicio, fim, ref alvoSoma)));
        }

        Task.WhenAll(tasks).Wait();
        return alvoSoma;
    }

    [Benchmark]
    public long SomaLerda()
    {
        return _vetor.Sum();
    }

}