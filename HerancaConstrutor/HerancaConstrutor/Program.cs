namespace HerancaConstrutor;

internal class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro("21301");
        carro.Teste();
    }
}

public class Veiculo
{
    private string numeroChassis;
    public Veiculo(string _numeroChassis)
    {
        numeroChassis = _numeroChassis;
        Console.WriteLine($"Inicializando Veículo: {numeroChassis}");
    }
    public Veiculo()
    {
        Console.WriteLine("Inicializando veículo");
    }

    public virtual void Teste()
    {
        Console.WriteLine("Acessei teste");
    }
}

public class Carro : Veiculo
{
    public Carro() // Da erro se comentar o construtor sem parâmetros de Veiculo, pois vai tentar inicializar o construto sem parâmetros e não existe mais esse construtor
    {
        Console.WriteLine("Inicializando Caro");
    }
    public Carro(string numeroChassis) : base(_numeroChassis: numeroChassis) // Acessar o construtor da classe base pasando no construtor esse argumetno
    {
        // Inicializar outros campos da classe Carro
        Console.WriteLine($"Inicializando Carro: {numeroChassis}");
    }
    public override void Teste()
    {
        base.Teste(); // Chamar método da classe base 
        Console.WriteLine("Sobrescrevi teste");
    }
}