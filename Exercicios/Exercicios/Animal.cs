namespace Heranca;
internal abstract class Animal // Não pode ser instanciada
{ // Fechada para alteração mas aberta para extensão
    public string Tipo { get; set; }
    public Animal(string tipo)
    {
        Tipo = tipo;
    }
    public abstract void Mover();
   
}
