using LiberacaoCredito.Models;

namespace LiberacaoCredito.Templates.ProcessamentoLiberacaoCredito
{
    public class ProcessamentoDireto : ProcessamentoTemplate
    {
        public override decimal TaxaJuros => 0.02m;
        public override string Produto => TipoCreditoEnum.DIRETO;
    }
}
