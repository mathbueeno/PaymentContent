using System;

namespace PaymentContext.Domain.Entities
{


    // Não se armazena Data do cartão, nem numeração completa, muito menos o ccv
    public class CreditCardPayment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }


}