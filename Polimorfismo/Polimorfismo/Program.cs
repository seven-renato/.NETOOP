using System.Runtime.CompilerServices;

namespace Polimorfismo;

internal class Program
{
    static void Main(string[] args)
    {
        // Polimorfismo com sobrescrita em tempo de execução
        var figuras = new List<Figura> // Circulo e Triangulo são figuras, não é necessário conversão
        {
            new Triangulo(), // Classes derivadas no lugar da classe Base
            new Circulo()
        };
        
        foreach (Figura f in figuras)
        {
            f.Desenhar();
        }  
    }
    // Polimorfismo com sobrecarga em tempo de compilação
    class Calcular
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
        public int Somar(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
