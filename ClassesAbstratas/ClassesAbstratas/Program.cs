namespace ClassesAbstratas;

internal class Program
{
    static void Main(string[] args)
    {
        Quadrado quadrado = new Quadrado();
        Console.WriteLine(quadrado.Descricao());

        Console.WriteLine("Informe a cor da figura");
        quadrado.Cor = Console.ReadLine();

        Console.WriteLine("Informe o lado do quadrado");
        quadrado.Lado = Convert.ToInt32(Console.ReadLine());

        quadrado.CalcularPerimetro();
        quadrado.CalcularArea();

        Console.WriteLine($"A área do quadrado é: {quadrado.Area} m2");
        Console.WriteLine($"O perímetro do quadrado é: {quadrado.Perimetro} m");
        Console.WriteLine($"A cor do quadrado é: {quadrado.Cor}");
    }
}
