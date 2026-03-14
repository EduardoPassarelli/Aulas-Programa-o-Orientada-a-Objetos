
using _1303;

Ipagamento clienteCeline = new PagamentoCartaoCredito();
clienteCeline.processarPagamento(450);
clienteCeline.estornarPagamento(450);
Ipagamento clienteFabio = new PagamentoPix();
clienteFabio.processarPagamento(300);
clienteFabio.estornarPagamento(300);

Ipagamento clienteJose = new PagamentoPayPal();
clienteJose.processarPagamento(200);
clienteJose.estornarPagamento(200);