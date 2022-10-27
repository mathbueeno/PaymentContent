using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    // Entidade - Pegamos de acordo com o que o cliente determina. No exemplo abaixo, trata-se de um site de cursos online.
    // É elencado quais informações precisam ser pegas do aluno, no caso, Nome - Documento - Email
    // Caso seja necessário adicionar outras informações, refatora e adiciona.
    // List- São as assinaturas dos alunos
    public class Student : Entity
    {
        // Aqui trata-se de Solid e Clean Code. 
        // "Se você está escrevendo um código pela 2x consecutiva, você precisa pensar em refatorar ele "

        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);


        }

        // Tipo Complexo 
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            // Se já tiver uma assinatura ativa, cancela.

            // Cancela todas as outras assinaturas e coloca esta como principal
            var = hasSubscriptionActive = false;
            foreach (var sub in _subscriptions)
            {
                if (sub.Active)
                    HasSubscriptionActive = true;
            }

            // AddNotifications(new Contract
            // .Requires()
            // .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa")
            // );

            // Alternativa 
            if (hasSubscriptionActive)
                AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");
        }
    }

}