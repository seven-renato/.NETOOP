namespace ClassesAbstratasXInterfaces;
internal class Quadrado : Figura
{
    public Quadrado(string nome) : base(nome){}
    public override void Desenhar()
    {
        Console.WriteLine($"Desenhando {Nome}...");
        Duplicar(); // Aqui herdamos a propriedade Nome e o método Duplicar da classe Abstrata
    }

    public override void Identificar()
    {
        Console.WriteLine($"Sou o : {Nome}");
    }
}
