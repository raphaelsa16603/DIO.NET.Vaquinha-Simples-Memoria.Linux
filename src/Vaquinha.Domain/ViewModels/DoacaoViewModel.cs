using System.ComponentModel;

namespace Vaquinha.Domain.ViewModels
{
    public class DoacaoViewModel
    {
        public decimal Valor { get; set; }

        [DisplayName("Pagar a taxa do serviço?")]
        public bool AceitaTaxa {get; private set;}

        public PessoaViewModel DadosPessoais { get; set; }
        public EnderecoViewModel EnderecoCobranca { get; set; }
        public CartaoCreditoViewModel FormaPagamento { get; set; }
    }
}