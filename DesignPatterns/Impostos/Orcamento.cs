using DesignPatterns.Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Items { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Items = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Items.Add(item);
        }
    }
}
