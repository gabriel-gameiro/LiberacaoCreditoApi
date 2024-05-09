using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LiberacaoCredito.Models
{
    public class RequisicaoSolicitacaoCredito
    {
        [Required]
        [Range(0.01, double.MaxValue)]
        [DefaultValue(1)]
        public decimal ValorCredito { get; set; }

        [Required]
        [DefaultValue("")]
        public string TipoCredito { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [DefaultValue(1)]
        public int QuantidadeParcelas { get; set; }

        [Required]
        public DateTime PrimeiroVencimento { get; set; }
    }
}
