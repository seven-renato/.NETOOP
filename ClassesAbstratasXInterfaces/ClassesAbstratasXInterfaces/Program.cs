namespace ClassesAbstratasXInterfaces;

internal class Program
{
    static void Main(string[] args)
    {
        var quadrado = new Quadrado("Quadrado");
        quadrado.Desenhar();
        quadrado.Identificar();

        Triangulo triangulo = new Triangulo("Triangulo");
        triangulo.Desenhar();
        triangulo.Identificar();
    }
}
