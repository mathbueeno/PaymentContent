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
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}