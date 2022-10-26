using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    // Entidade - Pegamos de acordo com o que o cliente determina. No exemplo abaixo, trata-se de um site de cursos online.
    // É elencado quais informações precisam ser pegas do aluno, no caso, Nome - Documento - Email
    // Caso seja necessário adicionar outras informações, refatora e adiciona.
    // List- São as assinaturas dos alunos
    public class Student
    {
        // Aqui trata-se de Solid e Clean Code. 
        // "Se você está escrevendo um código pela 2x consecutiva, você precisa pensar em refatorar ele "

        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

        }

        // Tipo Complexo 
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            // Se já tiver uma assinatura ativa, cancela.

            // Cancela todas as outras assinaturas e coloca esta como principal
            foreach (var sub in Subscriptions)
                sub.Inactivate();


            _subscriptions.Add(subscription);
        }
    }

}