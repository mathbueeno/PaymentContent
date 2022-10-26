using System;

namespace PaymentContext.Domain.Entities
{


    // Não se armazena Data do cartão, nem numeração completa, muito menos o ccv
    public class CreditCardPayment
    {
        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }


}