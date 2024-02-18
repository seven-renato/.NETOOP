using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao;
internal class Escola : IDisposable
{
    public string Nome {  get; set; }
    private List<Departamento> departamentos = new List<Departamento>();

    public void AddDepartamento(string nome)
    {
        departamentos.Add(new Departamento(this, nome));
    }
    public void Dispose()
    {
        foreach (var departamento in departamentos)
        {
            departamento.Dispose();
        }
    }
    private class Departamento : IDisposable
    {
        private Escola escola; // Propriedades privadas pois os departamentos não existem sem as escolas
        private string nome;

        internal Departamento(Escola escola, string nome)
        {
            this.escola = escola;
            this.nome = nome;
        }
        public void Dispose()
        {
            // Destroi departamento
        }

    }
}
