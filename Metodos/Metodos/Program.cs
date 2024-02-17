namespace Metodos;

internal class Program
{
    static public int Somar(int x, int y)
    {
        return (int)(x + y);
    }
    static public int Somar(int x, int y, int z)
    {
        return (int)(x + y + z);
    }
    static public double Somar(double x, double y)
    {
        return x + y;
    }
    static public double Somar(params int[] numeros)
    {
        var resultado = 0;
        foreach (int i in numeros)
        {
            resultado = (resultado + i);
        }
        return resultado;
    }

    public int Somar(int x, int y=20, int z=30, int w=50) 
    {
        return x + y + z + w;
    }

    static void Main(string[] args)
    {
        var resultado1 = Somar(100, 200);
        var resultado2 = Program.Somar(100, 200, 300);

        var resultado3 = Somar(new int[] { 1, 2, 3, });
        var resultado4 = Program.Somar(1, 2, 3, 4, 5, 6);
    }
}
