using System;

namespace Exercicio3
{
    public class Subtracao:Operacao
    {
        private int sub;
        public int Sub
        {
            get { return sub; }
            set { sub = value; }
        }
        
        public override void EfetuarOperacao()
        {
            this.sub = x - y;
            Console.WriteLine("O resultado da subtração é" + sub);
        }
    }
}