using ProgDistrib.PrimeiraQuestao.Services;

namespace ProgDistrib.PrimeiraQuestao.Saque;

public class AEconomica : SacadoraBase
{
    protected override int Valor => 5;
    protected override int Timeout => 12000;
}