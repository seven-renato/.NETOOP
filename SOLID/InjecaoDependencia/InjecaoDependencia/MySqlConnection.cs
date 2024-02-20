using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia;
internal class MySqlConnection : IDatabaseConnection
{
    public void Conectar()
    {
        Console.WriteLine("Conectado ao banco");
    }
}
