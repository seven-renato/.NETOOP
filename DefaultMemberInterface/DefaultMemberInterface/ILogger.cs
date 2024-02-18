namespace DefaultMemberInterface;
internal interface ILogger
{
    void Info(string mensagem);
    void Warn(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
}
