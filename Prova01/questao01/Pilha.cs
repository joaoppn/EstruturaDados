using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova01
{
    internal class Pilha
    {
        NoPilha topo;

        public Pilha()
        {
            topo = null;
        }

        public void Empilhar(char valor)
        {
            NoPilha novo = new NoPilha(topo, valor);
            topo = novo;
        }

        public char Desempilhar()
        {
            if (EstaVazia())
            {
                throw new Exception("A pilha está vazia!");
            }
            else
            {
                char valor = topo.Simbolo;
                topo = topo.Prox;
                return valor;
            }
        }

        public char Topo()
        {
            if (EstaVazia())
            {
                throw new Exception("A pilha está vazia!");
            }
            return topo.Simbolo;
        }

        public bool EstaVazia()
        {
            return topo == null;
        }


    }//end
}
