using ProgDistrib.PrimeiraQuestao.Services;

namespace ProgDistrib.PrimeiraQuestao.Deposito;

public class APatrocinadora : ServicoBase, IServico
{
    protected override int Valor => 100;
    protected override int Timeout => 5;
    
    public void Start()
    {
        while (true)
        {
            Thread.Sleep(Timeout);
            if (Conta.Saldo != 0) continue;
            
            var resultado = Conta.Depositar(Valor);
            LogDeposito(resultado);   
        }
    }
}