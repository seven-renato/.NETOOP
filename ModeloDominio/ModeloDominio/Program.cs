namespace ModeloDominio;

internal class Program
{
    static void Main(string[] args)
    {
        ClienteRico cliente = new ClienteRico(-1, "", null);
    }
    private static ClienteAnemico ClienteAnemico()
    {
        ClienteAnemico clienteAnemico = new ClienteAnemico();
        clienteAnemico.Id = 1;
        clienteAnemico.Nome = "";
        clienteAnemico.Endereco = null;
        return clienteAnemico;
    }
}
