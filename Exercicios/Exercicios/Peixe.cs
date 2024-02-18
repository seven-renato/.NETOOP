namespace Heranca;
internal class Peixe : Animal
{
    public Peixe(string tipo): base(tipo){}
    public override void Mover()
    {
        Console.WriteLine("Eu estou nadando!");
    }
}
