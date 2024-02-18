using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao;
internal class Departamento : IDisposable
{
    public string Nome { get; set; }
    public List<Professor> Professores { get; set; }

    public void Dispose() { }

}
