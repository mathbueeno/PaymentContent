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
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
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