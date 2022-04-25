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
        public double Valor { get; set; }
        public IList<Item> Items { get; private set; }
        public EstadoDeUmOrcamento Estado { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Items = new List<Item>();
            Estado = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Items.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            Estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            Estado.Aprova(this);
        }

        public void Reprova()
        {
            Estado.Reprova(this);
        }

        public void Finaliza()
        {
            Estado.Finaliza(this);
        }
    }
}
