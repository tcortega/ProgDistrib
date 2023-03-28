using ProgDistrib.PrimeiraQuestao.Services;

namespace ProgDistrib.PrimeiraQuestao.Saque;

public class AGastadora : SacadoraBase
{
    protected override int Valor => 10;
    protected override int Timeout => 3000;
}