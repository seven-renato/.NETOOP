namespace ModeloAnemico1;

internal class Program
{
    static void Main(string[] args)
    {
        Item item = new Item(1, 2, "Joca", 100000);
        Console.WriteLine(item.ItemPreco);
    }
}
