using Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Impostos
{
    public interface EstadoDeUmOrcamento
    {
        bool Descontado { get; set; }
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }

    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public bool Descontado { get; set; }

        public EmAprovacao()
        {
            Descontado = false;
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!Descontado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                Descontado = true;
            }
            else throw new Exception("Desconto já foi aplicado.");
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamentos em aprovação não podem ser finalizados diretamente.");
        }
    }

    public class Aprovado : EstadoDeUmOrcamento
    {
        public bool Descontado { get; set; }

        public Aprovado()
        {
            Descontado = false;
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!Descontado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                Descontado = true;
            }
            else throw new Exception("Desconto já foi aplicado.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado Aprovado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }

    public class Reprovado : EstadoDeUmOrcamento
    {
        public bool Descontado { get; set; }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado e não pode ser aprovado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está no estado reprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }

    public class Finalizado : EstadoDeUmOrcamento
    {
        public bool Descontado { get; set; }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado.");
        }
    }
}
