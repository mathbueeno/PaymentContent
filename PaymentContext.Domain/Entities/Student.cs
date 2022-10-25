namespace PaymentContext.Domain.Entities
{
    // Entidade - Pegamos de acordo com o que o cliente determina. No exemplo abaixo, trata-se de um site de cursos online.
    // É elencado quais informações precisam ser pegas do aluno, no caso, Nome - Documento - Email
    // Caso seja necessário adicionar outras informações, refatora e adiciona.
    // List- São as assinaturas dos alunos
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }

}