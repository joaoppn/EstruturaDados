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
        int tam;

        public Pilha()
        {
            topo = null;
            tam = 0;
        }

        public void Empilhar(string valor)
        {
            NoPilha novo = new NoPilha(topo, valor);
            topo = novo;
        }

        public string Desempilhar()
        {
            if (EstaVazia())
            {
                throw new Exception("A pilha está vazia!");
            }
            else
            {
                string valor = topo.Simbolo;
                topo = topo.Prox;
                return valor;
            }
        }

        public string Topo()
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

        public bool retirar_valor(string valor)
        {
            Pilha guarda = new Pilha();
            if (achar(valor))
            {
                while(topo.Simbolo != valor)
                {
                    guarda.Empilhar(Desempilhar());
                }
                Desempilhar();
                while(guarda.topo != null)
                {
                    Empilhar(guarda.Desempilhar());
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool achar(string valor)
        {
            NoPilha contador = topo;
            while(contador != null)
            {
                if(contador.Simbolo == valor)
                {
                    return true;
                }
                else
                {
                    contador = contador.Prox;
                }
            }
            return false;
        }

        public string imprimir()
        {
            NoPilha contador = topo;
            String Lista = "";
            while(contador != null)
            {
                Lista = Lista + " | " + contador.Simbolo;
                contador = contador.Prox;
            }
            return Lista;
        }

        public int Tam { get => tam;set=> tam = value; }


    }//end
}
