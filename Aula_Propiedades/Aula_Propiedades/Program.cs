namespace Aula_Propriedades;

internal class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Mario");
        pessoa.Genero = "masculino";
        pessoa.Idade = 17;
        Console.WriteLine(pessoa.Nome);
        Console.WriteLine(pessoa.Idade);
    }
}
