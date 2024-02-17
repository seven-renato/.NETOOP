namespace ConsoleApp1; // Container de classes

internal partial class Program
{
    static void Main(string[] args) // Static -> Não precisa criar uma instância da classe para utilizar
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Paulo";
        pessoa1.idade = 1;
        pessoa1.genero = 'M'.ToString();
        pessoa1.Identificar();

        Pessoa pessoa2 = new Pessoa("Jose", 10, "Masculino");
    }
}
