using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303
{
    public class PagamentoCartaoCredito : Pagamento, Ipagamento
    {
        public void processarPagamento(decimal _valorPagamento)
        {
            valorPagamento = _valorPagamento;
            Console.WriteLine($"Pagamento efetuado com cartão de crédito: {_valorPagamento}");
        }

        public void estornarPagamento(decimal _valorPagamento) {
            valorPagamento = _valorPagamento;
            Console.WriteLine($"Pagamento com cartão de crédito estornado: {_valorPagamento}");
                
                }
    }
}
