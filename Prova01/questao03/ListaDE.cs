using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_listaDE
{
    internal class ListaDE
    {
        //atributos

        NoLista inicio;
        NoLista fim;

        //metodos
        public ListaDE()
        {
            Inicio = null;
            Fim = null;
        }

        public bool estaVazia()
        {
            if (Inicio == null)
            { return true; }
            else
            { return false; }
        }

        public string imprimi()
        {
            string lista = "";
            NoLista temp = Inicio;

            if(estaVazia())
            {
                MessageBox.Show("A lista esta vazia");
                return lista;
            }
            else
            {
                while(temp != null)
                {
                    lista = lista + " | " + Convert.ToString(temp.Info);
                    temp = temp.Next;
                }
                return lista;
            }
        }

        public void add(double valor)
        {
            NoLista novo = new NoLista(valor);
            NoLista contador = inicio;
            if (estaVazia())
            {
                Inicio = novo;
                Fim = novo;
            }
            else
            {
                if(inicio.Info > valor)
                {
                    novo.Next = inicio;
                    inicio.Prev = novo;
                    inicio = novo;

                }
                else if(fim.Info < valor)
                {
                    fim.Next = novo;
                    novo.Prev = fim;
                    fim= novo;
                }
                else
                {
                    while(contador.Next.Info < valor)
                    {
                        contador = contador.Next;
                    }
                    contador.Next.Prev = novo;
                    novo.Next = contador.Next;
                    contador.Next = novo;
                    novo.Prev = contador;

                }

            }
        }



        public bool remove_valor(double valor)
        {
            NoLista contador = inicio;
            while (contador != null)
            {
                if (contador.Info == valor)
                {
                    contador.Next.Prev = contador.Prev;
                    contador.Prev.Next = contador.Next;
                    return true;
                }
                else { contador = contador.Next; }
                
            }
            return false;
        }


        internal NoLista Inicio { get => inicio; set => inicio = value; }
        internal NoLista Fim { get => fim; set => fim = value; }
    }//fim
}
