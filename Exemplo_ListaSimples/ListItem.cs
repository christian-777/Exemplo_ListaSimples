using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_ListaSimples
{
    internal class ListItem
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListItem()
        {
            Begin = null;
            End = null;
        }

        public void Insert(Item i)
        {
            if (IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else
            {
                if (i.Value <= Begin.Value)
                {
                    InsertFirst(i);
                }
                else
                {
                    if(i.Value >= End.Value)
                    {
                        InsertLast(i);
                    }
                    else
                    {
                        InsertMiddle(i);
                    }
                }

            }
        }

        private void InsertMiddle(Item i)
        {
            Item aux1=Begin;
            Item aux2=Begin.Next;

            while (aux2 != null)
            {
                if(i.Value < aux2.Value) 
                {
                    i.Next = aux2;
                    aux1.Next = i;
                    return;
                }
                aux1 = aux2;
                aux2 = aux2.Next;
            }

        }

        private void InsertLast(Item i)
        {
            End.Next = i;
            End = i;
        }

        private void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
        }

        public Item Find(string i)
        {
            Item aux = Begin;
            while (aux != null)
            {
                if (string.Compare(aux.Letter, i)==0)
                {
                    return aux;
                }
                aux = aux.Next;
            }
            aux = null;
            return aux;
        }

        public bool IsEmpty()
        {
            if(Begin == null)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            int i = 0;
            if (IsEmpty())
            {
                Console.WriteLine("lista vazia");
            }
            else
            {
                Item aux = Begin;
                Console.WriteLine("Os elementos da lista sao:");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Next;
                } while (aux != null);
                Console.WriteLine("Final da lista\n");
            }
        }
    }
}
