namespace ProgDistrib.QuartaQuestao;

public static class SomaThread
{
    private static readonly object Lock = new();
    public static void Somar(int[] vetor, long inicio, long fim, ref long alvoSoma)
    {
        long soma = 0;
        for (var i = inicio; i < fim; i++)
            soma += vetor[i];

        lock (Lock)
            alvoSoma += soma;
    }
}