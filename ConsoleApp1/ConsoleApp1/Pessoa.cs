namespace ConsoleApp1; // Container de classes

internal partial class Program
{
    class Pessoa
    {
        // Fields
        public string nome { get; set; } = string.Empty;
        public int idade;
        public string genero;
        // Constructor
        public Pessoa()
        {
            nome = "Jose";
            idade = 55;
            genero = "Masculino";
        }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            genero = "Masculino";
        }
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }
        // Methods
        public void Identificar()
        {
            Console.WriteLine($"Ola, sou {nome}, tenho {idade} anos e sou do sexo {genero}");
        }
    }
}
