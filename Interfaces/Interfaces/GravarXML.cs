using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces;
internal class GravarXML : ArquivoBase, IGravar
{
    public void GravarArquivo()
    {
        throw new NotImplementedException();
    }
    public override void Nome()
    {
        Console.WriteLine("Definir nome em GravarXML");
    }
}
