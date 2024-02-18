using Heranca;
namespace Exercicios;

internal class Program
{
    static void Main(string[] args)
    {
        Animal peixe = new Peixe("Bagre");
        peixe.Mover(); // Usando método da classe derivada através da classe base

        Animal ave = new Ave("Pato");
        ave.Mover(); // Em tempo de execução isso está sendo chamado
    }
}
