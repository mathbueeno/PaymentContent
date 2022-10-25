namespace PaymentContext.Domain.Entities
{
    // Assinatura do Aluno - Se está ativa, se houve pagamento, dia que termina
    // ? no final - Nullable - significa que pode ser nulo
    public class Subscription
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Active { get; set; }
        public List<Payment> Payments { get; set; }
    }
}