namespace DefaultMemberInterface;

internal class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.Warn("Erro");

        ConsoleLogger consoleLogger = new ConsoleLogger();
        consoleLogger.Warn(); // Não existe implementação, já da um erro de compilação
    }
}
