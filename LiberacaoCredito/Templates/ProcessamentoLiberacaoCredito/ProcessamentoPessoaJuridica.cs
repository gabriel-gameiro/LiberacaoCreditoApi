using LiberacaoCredito.Models;

namespace LiberacaoCredito.Templates.ProcessamentoLiberacaoCredito
{
    public class ProcessamentoPessoaJuridica : ProcessamentoTemplate
    {
        public override decimal TaxaJuros => 0.05m;
        public override string Produto => TipoCreditoEnum.PESSOA_JURIDICA;

        public override bool Validar(RequisicaoSolicitacaoCredito solicitacaoCredito)
        {
            // Caso alguma das validações padrões rejeitem, já retorno
            if(!base.Validar(solicitacaoCredito))
                return false;

            // Validação exlusiva do produto PJ
            if (solicitacaoCredito.ValorCredito < 15_000)
                return false;

            return true;
        }
    }
}
