using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()
                .IsRequires()
                .IsEmail(Address, "Email.Address", "Email inválido")
            );
        }

        public string Address { get; private set; }

    }
}