using LiberacaoCredito.Models;

namespace LiberacaoCredito.Templates.ProcessamentoLiberacaoCredito
{
    public class ProcessamentoPessoaFisica : ProcessamentoTemplate
    {
        public override decimal TaxaJuros => 0.03m;

        public override string Produto => TipoCreditoEnum.PESSOA_FISICA;
    }
}
