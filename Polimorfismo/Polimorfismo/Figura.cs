using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo;
internal class Figura
{
    public int Lado { get; set; }
    public virtual void Desenhar()
    {
        Console.WriteLine("Executando desenhar na classe base");
    }
}
