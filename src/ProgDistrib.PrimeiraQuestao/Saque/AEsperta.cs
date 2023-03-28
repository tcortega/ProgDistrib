using ProgDistrib.PrimeiraQuestao.Services;

namespace ProgDistrib.PrimeiraQuestao.Saque;

public class AEsperta : SacadoraBase
{
    protected override int Valor => 50;
    protected override int Timeout => 6000;
}