using LiberacaoCredito.Models;

namespace LiberacaoCredito.Templates.ProcessamentoLiberacaoCredito
{
    public abstract class ProcessamentoTemplate
    {
        public abstract string Produto { get; }
        public abstract decimal TaxaJuros { get; }

        // Metodo comum para todos os produtos financeiros
        public decimal CalcularJuros(decimal valorSolicitado)
        {
            return valorSolicitado * TaxaJuros;
        }

        // Metodo comum para quase todos os produtos financeiros
        public virtual bool Validar(RequisicaoSolicitacaoCredito solicitacaoCredito)
        {
            if (solicitacaoCredito.ValorCredito > 1_000_000)
                return false;

            if(solicitacaoCredito.QuantidadeParcelas < 5 || solicitacaoCredito.QuantidadeParcelas > 72)
                return false;

            DateTime dataAtual = DateTime.Now;
            double diasPrimeiroVencimento = (solicitacaoCredito.PrimeiroVencimento - dataAtual).TotalDays;
            if (diasPrimeiroVencimento < 15 || diasPrimeiroVencimento > 40)
                return false;

            return true;
        }

        // Metodo comum que dita os passos que devem ser executados para o processamento
        public RetornoSolicitacaoCredito ProcessarSolicitacao(RequisicaoSolicitacaoCredito solicitacaoCredito)
        {
            RetornoSolicitacaoCredito retornoSolicitacaoCredito = new RetornoSolicitacaoCredito();

            if (Validar(solicitacaoCredito))
            {
                retornoSolicitacaoCredito.StatusCredito = "Aprovado";
                retornoSolicitacaoCredito.ValorJuros = CalcularJuros(solicitacaoCredito.ValorCredito);
                retornoSolicitacaoCredito.ValorTotal = solicitacaoCredito.ValorCredito + retornoSolicitacaoCredito.ValorJuros;
            }
            else
            {
                retornoSolicitacaoCredito.StatusCredito = "Reprovado";
            }

            return retornoSolicitacaoCredito;
        }
    }
}
