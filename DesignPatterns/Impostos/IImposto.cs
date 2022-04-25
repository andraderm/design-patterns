namespace Impostos
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }

        public IImposto() 
        {
            OutroImposto = null;
        }

        public IImposto(IImposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);
        public double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
