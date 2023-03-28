using ProgDistrib.PrimeiraQuestao.Services;

namespace ProgDistrib.PrimeiraQuestao.Saque;

public abstract class SacadoraBase : ServicoBase, IServico
{
    public void Start()
    {
        while (true)
        {
            Thread.Sleep(Timeout);
            if (Conta.Saldo < Valor) continue;
            
            var resultado = Conta.Sacar(Valor);
            LogSaque(resultado);
        }
    }
}