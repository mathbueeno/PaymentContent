using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        // Criação de Instância
        var subscription = new Subscription(null);
        var student = new Student("Matheus", "Bueno", "123654", "bueno@gmail.com");
        student.AddSubscription(subscription);

    }
}