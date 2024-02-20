namespace InjecaoDependencia;

internal class Program
{
    static void Main(string[] args)
    {
        IDatabaseConnection con = new MySqlConnection();
        RecuperaSenha recuperaSenha = new RecuperaSenha(con);
    }
}
