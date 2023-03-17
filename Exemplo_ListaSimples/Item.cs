using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_ListaSimples
{
    internal class Item
    {
        public int Value { get; set; }
        public string Letter { get; set; }
        public Item Next { get; set; }

        public Item(int x, string c)
        {
            Value = x;
            Letter = c;
            Next = null;
        }

        public override string ToString()
        {
            return ("\n"+Value+"-"+Letter);
        }
    }
}
