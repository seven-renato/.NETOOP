namespace Aula_Propriedades;
internal class Pessoa
{
    private string nome;
    private string genero;
    private int idade;
    public Pessoa(string nome)
    {
        this.nome = nome;
    }
    public string Nome { get; }
    public string Genero
    {
        set
        {
            genero = value;
            Console.WriteLine(genero);
        }
    }
    public int Idade
    {
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Idade deve ser maior que 18");
        }
            else
            {
                this.idade = value;
            }
        }
        get { return idade; }
    }
}
