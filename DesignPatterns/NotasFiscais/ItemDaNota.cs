using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NotasFiscais
{
    public class ItemDaNota
    {
        public double Valor { get; set; }
        public string Nome { get; set; }

        public ItemDaNota(double valor, string nome)
        {
            Valor = valor;
            Nome = nome;
        }
    }
}
