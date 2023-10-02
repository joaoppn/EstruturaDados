using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_listaDE
{
    internal class NoLista
    {
        //atributoa
        NoLista prev;
        NoLista next;
        double info;

        //construtor

        public NoLista()
        {
            prev = null;
            next = null;
            Info = 0;

        }

        public NoLista(double valor)
        {
            prev = null;
            next = null;
            Info = valor;
        }

        //getters and setters

        public double Info { get => info; set => info = value; }
        internal NoLista Prev {  get => prev; set => prev = value;}
        internal NoLista Next { get => next; set => next = value;}

    }//fim
}
