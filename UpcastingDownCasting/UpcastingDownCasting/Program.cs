namespace UpcastingDownCasting;

internal class Program
{
    static void Main(string[] args)
    {
        Forma f = new Forma();
        Circulo c = f as Circulo;
        if (c!=null)
        {
            c.PintarCirculo();
        }
        else
            Console.WriteLine("Operação de downcast inválida (as)");

        Circulo circulo = new Circulo();
        Forma f2 = circulo;

        if (f is Circulo)
        {
            ((Circulo)f).PintarCirculo();
        }
        else
        {
            Console.WriteLine("Operação de downcast inválida (is) ");
        }

    }
    private static void DownCastingAndUpcasting()
    {
        Circulo circulo = new Circulo();
        Forma f = circulo; // Upcasting
        Console.WriteLine(f == circulo); // True as duas referencias apontam ao mesmo objeto
        f.Desenhar();

        Circulo c = (Circulo)f; // DownCasting

        Console.WriteLine(c == f); // True ->
        Console.WriteLine(c == circulo); // -> True -> Apontam ambas a mesma refêrencia
        c.Desenhar();
        c.PintarCirculo();// Agora posso utilizar outros métodos além de desenhar pois é do tipo Circulo
    }
}
