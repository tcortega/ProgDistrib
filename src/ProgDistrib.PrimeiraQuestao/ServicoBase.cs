using ProgDistrib.PrimeiraQuestao.Services;

namespace ProgDistrib.PrimeiraQuestao;

public abstract class ServicoBase
{
    protected static Conta Conta => Conta.Instancia;
    private readonly string _nomeServico;
    protected abstract int Valor { get; }
    protected abstract int Timeout { get; }

    protected ServicoBase()
    {
        _nomeServico = GetType().Name;
    }
    
    protected void Log(string message)
    {
        Console.WriteLine($"[{_nomeServico}] {message}");
    }

    protected void LogSaque(bool resultado)
    {
        Log(!resultado ? $"Não foi possível sacar o valor de {Valor}" : $"Foi efetuado um saque no valor de R$ {Valor}");
    }

    protected void LogDeposito(bool resultado)
    {
        Log(!resultado ? $"Não foi possível depositar o valor de {Valor}" : $"Foi efetuado um depósito no valor de R$ {Valor}");
    }
}