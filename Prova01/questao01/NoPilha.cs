using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova01
{
    internal class NoPilha
    {
        NoPilha prox;
        char simbolo;

        public NoPilha()
        {
            prox = null;
        }

        public NoPilha(NoPilha a, char b)
        {
            prox = a;
            simbolo = b;
        }

        public char Simbolo { get => simbolo;  set  => simbolo = value;  }
        internal NoPilha Prox { get => prox; set => prox = value; }

    }//end
}
