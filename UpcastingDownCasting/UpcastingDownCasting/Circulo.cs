namespace UpcastingDownCasting;

public class Circulo : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("Circulo");
    }

    public void PintarCirculo()
    {
        Console.WriteLine("Pintando o círculo");
    }
}
