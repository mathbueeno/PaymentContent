using System;

namespace PaymentContext.Domain.Entities
{
    // Pagamentos possui informações distintas - Nome da pessoa no cartão, últimos digitos e CPF.
    // Colocamos portanto 4 entidades de pagamentos distintas, pois cada uma possui uma caracteristica. Sempre será necessário instanciar algum tipo de pagamento.

    // Abstract - significa que ela fica em abstrato, tendo que ser relacionada o qualquer outro tipo abaixo, por exemplo : Boleto
    public abstract class Payment
    {
        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Owner { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }

    public class BoletoPayment
    {
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }

    // Não se armazena Data do cartão, nem numeração completa, muito menos o ccv
    public class CreditCardPayment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }

    public class PayPalPayment
    {
        public string TransactionCode { get; set; }
    }
}