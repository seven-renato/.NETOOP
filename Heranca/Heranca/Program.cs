namespace Heranca;

class Conta
{
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public Conta()
    {
        Console.WriteLine("Construtor da classe Conta");
    }

    protected void GetSaldo()
    {
        Console.WriteLine("Saldo 99,99");
    }
}

class ContaPoupanca : Conta
{
    public int JurosMensais { get; set; }

    protected new void GetSaldo()
    {
        Console.WriteLine("Saldo 88,88");
    }

    static void Main(string[] args)
    {
        ContaPoupanca cp = new ContaPoupanca();
        cp.Saldo = 100;
        cp.JurosMensais = 100;
        cp.GetSaldo();
    }
}

