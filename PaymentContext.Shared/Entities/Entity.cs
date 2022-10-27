using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        // Entidades possuem ID, Value Object não possui
        public Guid Id { get; set; }
    }

}