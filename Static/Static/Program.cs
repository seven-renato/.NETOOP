namespace Static;

internal class Program
{
    static void Main(string[] args)
    {
        TesteEstatico.Method();
        TesteEstatico testeEstatico = new TesteEstatico();
        testeEstatico.Method2();
    }
}
