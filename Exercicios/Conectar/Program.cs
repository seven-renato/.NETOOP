namespace Conectar;

internal class Program
{
    static void Main(string[] args)
    {
        Transacao t1 = new Transacao();
        t1.Conectar();
        t1.Executa();
        t1.Imprimir();
    }
}
