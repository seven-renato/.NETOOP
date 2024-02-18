namespace Interfaces;

internal class Program
{
    static void Main(string[] args)
    {
        GravarXML gravar = new GravarXML();
        gravar.GravarArquivo();
        gravar.Nome();
        
        // Usando a interface
        IGravar igravar = new GravarXML();
        igravar.GravarArquivo();

        Console.WriteLine("Hello, World!");
    }
}
