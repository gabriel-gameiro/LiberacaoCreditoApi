using LiberacaoCredito.Models;

namespace LiberacaoCredito.Templates.ProcessamentoLiberacaoCredito
{
    public class ProcessamentoImobiliario : ProcessamentoTemplate
    {
        public override decimal TaxaJuros => 0.09m;
        public override string Produto => TipoCreditoEnum.IMOBILIARIO;
    }
}
