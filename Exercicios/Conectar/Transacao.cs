namespace Conectar;
internal class Transacao : ConectarBancoDados, ITransacao, IRelatorio
{
    public void Executa()
    {
        Console.WriteLine("Processando Transação...");
    }

    public void Imprimir()
    {
        Console.WriteLine("Imprimindo...");
    }
}
