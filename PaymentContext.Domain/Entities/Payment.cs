using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    // Pagamentos possui informações distintas - Nome da pessoa no cartão, últimos digitos e CPF.
    // Colocamos portanto 4 entidades de pagamentos distintas, pois cada uma possui uma caracteristica. Sempre será necessário instanciar algum tipo de pagamento.

    // Abstract - significa que ela fica em abstrato, tendo que ser relacionada o qualquer outro tipo abaixo, por exemplo : Boleto
    public abstract class Payment
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, Document document, Address address, Email email)
        {
            //1- Gerou novo Guid, 2- Converteu para String, 3- Removeu o traço, 4- pegou 10 primeiros caracteres
            // 5- Deixou maiúsculo

            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Owner { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }

    }


}