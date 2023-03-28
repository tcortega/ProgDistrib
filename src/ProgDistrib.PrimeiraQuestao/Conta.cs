namespace ProgDistrib.PrimeiraQuestao;

public class Conta
{
    public static Conta Instancia { get; private set; }
    private readonly object _lock = new();
    
    private Conta(long numero, string titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;

        Instancia = this;
    }

    public long Numero { get; }
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public static Conta Criar(long numero, string titular, decimal saldo = 0)
    {
        // Create validation for each parameter
        if (numero <= 0) throw new ArgumentOutOfRangeException(nameof(numero), "Número de conta inválido");
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("O nome do titular da conta não pode estar vazio", nameof(titular));
        
        if (saldo < 0) throw new ArgumentOutOfRangeException(nameof(saldo), "O saldo inicial não pode ser menor que 0");

        return new Conta(numero, titular, saldo);
    }
    
    public bool Depositar(decimal valor)
    {
        if (valor <= 0)
            return false;
        
        lock (_lock)
        {
            Saldo += valor;
            return true;
        }
    }

    public bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo) return false;
        lock (_lock)
        {
            if (valor > Saldo)
                return false;
            
            Saldo -= valor;
            return true;
        }
    }
}