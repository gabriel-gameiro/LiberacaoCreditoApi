using LiberacaoCredito.Models;
using LiberacaoCredito.Templates.ProcessamentoLiberacaoCredito;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace LiberacaoCredito.Services
{
    public class ProcessamentoLiberacaoService
    {
        // Dicionario com as implementacoes da Template de processamento
        private Dictionary<string, ProcessamentoTemplate> processors = new Dictionary<string, ProcessamentoTemplate>();

        public ProcessamentoLiberacaoService()
        {
            RegistrarProcessor(new ProcessamentoDireto());
            RegistrarProcessor(new ProcessamentoConsignado ());
            RegistrarProcessor(new ProcessamentoPessoaJuridica ());
            RegistrarProcessor(new ProcessamentoPessoaFisica ());
            RegistrarProcessor(new ProcessamentoImobiliario ());
        }

        private void RegistrarProcessor(ProcessamentoTemplate processor)
        {
            processors.Add(processor.Produto, processor);
        }

        public RetornoSolicitacaoCredito ProcessarSolicitacaoCredito(RequisicaoSolicitacaoCredito solicitacaoCredito)
        {
            if (processors.ContainsKey(solicitacaoCredito.TipoCredito))
            {
                return processors[solicitacaoCredito.TipoCredito].ProcessarSolicitacao(solicitacaoCredito);
            }
            else
            {
                throw new ApplicationException("Tipo de crédito solicitado inválido!");
            }
        }


    }
}
