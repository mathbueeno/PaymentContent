// Value Objects são tipos que compõem uma entidade.

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
            if (string.IsNullOrEmpty(name.FirstName))
                AddNotification("Name.FirstName", "Nome Inválido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}