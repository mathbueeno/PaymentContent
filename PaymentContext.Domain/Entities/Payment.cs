using System;

namespace PaymentContext.Domain.Entities
{
    // Pagamentos possui informações distintas - Nome da pessoa no cartão, últimos digitos e CPF.
    // Colocamos portanto 4 entidades de pagamentos distintas, pois cada uma possui uma caracteristica.

    // Abstract - significa que ela fica em abstrato, tendo que ser relacionada o qualquer outro tipo abaixo, por exemplo : Boleto
    public abstract class Payment
    {
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }

    }

    public class BoletoPayment
    {

    }

    public class CreditCardPayment
    {

    }

    public class PayPalPayment
    {

    }
}