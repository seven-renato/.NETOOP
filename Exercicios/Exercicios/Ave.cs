namespace Heranca;
internal class Ave : Animal
{
    public Ave(string tipo) : base(tipo){}
    public override void Mover()
    {
        Console.WriteLine("Eu estou voando!");
    }
}
