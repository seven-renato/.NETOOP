using System;

namespace CursoFoop_Acoplamento_Composicao
{
    class Gato
    {
        public Animal gato = new Animal();
        public ComportamentoAndar andar = new ComportamentoAndar();
        public void Miau()
        {
            Console.WriteLine("miau...");
        }
    }
}
