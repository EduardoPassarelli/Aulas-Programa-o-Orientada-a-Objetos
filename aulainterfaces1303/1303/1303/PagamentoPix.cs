using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303
{
    public class PagamentoPix : Pagamento, Ipagamento
    {
        public void processarPagamento(decimal _valorPagamento) {
            valorPagamento = _valorPagamento;
            Console.WriteLine($"Pagamento realizado com pix.{_valorPagamento}");
        }
        public void estornarPagamento(decimal _valorPagamento)
        {
            valorPagamento = _valorPagamento;
            Console.WriteLine($"Pagamento com pix estornado: {_valorPagamento}");

        }
    }
}
