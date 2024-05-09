using LiberacaoCredito.Models;
using LiberacaoCredito.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LiberacaoCredito.Controllers
{
    public class LiberacaoController : Controller
    {
        ProcessamentoLiberacaoService _processamentoLiberacaoService;

        public LiberacaoController(ProcessamentoLiberacaoService processamentoLiberacaoService)
        {
            _processamentoLiberacaoService = processamentoLiberacaoService;
        }

        [Route("/ProcessarRequisicao")]
        [HttpPost()]
        public ActionResult ProcessarLiberacao([FromBody] RequisicaoSolicitacaoCredito solicitacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna 400 com os erros de validação
            }

            try
            {
                RetornoSolicitacaoCredito retorno = _processamentoLiberacaoService.ProcessarSolicitacaoCredito(solicitacao);
                return new OkObjectResult(retorno);
            }
            // Erro tratado
            catch (ApplicationException ex)
            {
                // Realizar um log do erro aqui
                return new BadRequestObjectResult(ex.Message);
            }
            // Erro inesperado
            catch (Exception ex)
            {
                // Realizar um log do erro aqui

                return new BadRequestResult();
            }
        }
    }
}
