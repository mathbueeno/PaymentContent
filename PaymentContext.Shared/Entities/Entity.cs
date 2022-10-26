namespace PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        // Entidades possuem ID, Value Object não possui
        public Guid Id { get; set; }
    }

}