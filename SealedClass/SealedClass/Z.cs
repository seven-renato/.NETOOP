using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass;
internal class Z : Y
{
    protected override void F()
    {
        Console.WriteLine("Z.F");
    }
    protected override void F2()
    {
        Console.WriteLine("Z.F2");
    }
}
