namespace PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        {
            Id = Guid.NewGuid();
        }

        // Entidades possuem ID, Value Object não possui
        public Guid Id { get; set; }
    }

}