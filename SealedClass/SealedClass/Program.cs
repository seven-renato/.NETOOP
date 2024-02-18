namespace SealedClass;

internal class Program
{
    static void Main(string[] args)
    {
        CalculaSoma calculaSoma = new CalculaSoma();
        calculaSoma.Somar(1,3);
    }
}

sealed class CalculaSoma
{
    public int Somar(int a, int b) { return a + b; }
}

//class Calculadora : CalculaSoma 
//{

//}

