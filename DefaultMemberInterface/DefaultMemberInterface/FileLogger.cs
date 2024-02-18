using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMemberInterface;
internal class FileLogger : ILogger
{
    public void Info(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
}
