// Value Objects são tipos que compõem uma entidade.

namespace PaymentContext.Domain.ValueObjects
{
    public class Name
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