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
        string simbolo;

        public NoPilha()
        {
            prox = null;
        }

        public NoPilha(NoPilha a, string b)
        {
            prox = a;
            simbolo = b;
        }

        public string Simbolo { get => simbolo;  set  => simbolo = value;  }
        internal NoPilha Prox { get => prox; set => prox = value; }

    }//end
}
