namespace DefaultMemberInterface;
internal class ConsoleLogger : ILogger
{
    public void Info(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
}
