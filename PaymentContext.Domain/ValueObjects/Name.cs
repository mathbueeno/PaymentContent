// Value Objects são tipos que compõem uma entidade.


using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject

    {
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            // Validação - Se o primeiro nome for nulo ou vazio,
            AddNotifications(new Contract
                .IsRequires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(FirstName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
            );


        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}