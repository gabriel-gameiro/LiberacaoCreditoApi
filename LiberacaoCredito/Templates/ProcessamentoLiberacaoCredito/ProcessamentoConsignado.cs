using LiberacaoCredito.Models;

namespace LiberacaoCredito.Templates.ProcessamentoLiberacaoCredito
{
    public class ProcessamentoConsignado : ProcessamentoTemplate
    {
        public override decimal TaxaJuros => 0.01m;

        public override string Produto => TipoCreditoEnum.CONSIGNADO;
    }
}
