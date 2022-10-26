using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment
    {
        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}