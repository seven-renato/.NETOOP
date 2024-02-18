using CursoFoop_InterfaceDesacopla1;

namespace InterfacesDesacopladas;

internal class Program
{
    static void Main(string[] args)
    {
        var registraOcorrenciasConsole = new RegistraOcorrencias(new RegistrarNoConsole());
        var registraOcorrenciasArquivo = new RegistraOcorrencias(new RegistrarNoArquivo(@"D:\\"));
        registraOcorrenciasConsole.Registrar("Registro console");
        registraOcorrenciasArquivo.Registrar("Registro arquivo");
    }
}
