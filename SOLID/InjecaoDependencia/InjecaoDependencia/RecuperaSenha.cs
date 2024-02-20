using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia;
internal class RecuperaSenha
{
    private readonly IDatabaseConnection _databaseConnection; 
    public RecuperaSenha(IDatabaseConnection databaseConnection)
    {

        _databaseConnection = databaseConnection;

    }
}
