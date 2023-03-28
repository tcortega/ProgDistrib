namespace ProgDistrib.QuartaQuestao;

public static class SomaThread
{
    public static long Somar(int[] vetor, long inicio, long fim)
    {
        long soma = 0;
        for (var i = inicio; i < fim; i++)
            soma += vetor[i];

        return soma;
    }
}