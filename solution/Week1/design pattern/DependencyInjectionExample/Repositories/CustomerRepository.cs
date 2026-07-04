namespace DependencyInjectionExample.Repositories;

public record Customer(int Id, string Name);

public interface ICustomerRepository
{
    Customer? FindCustomerById(int id);
}

public class CustomerRepositoryImpl : ICustomerRepository
{
    private readonly List<Customer> _customers =
    [
        new(1, "Alice"), new(2, "Bob"), new(3, "Charlie")
    ];

    public Customer? FindCustomerById(int id) =>
        _customers.FirstOrDefault(c => c.Id == id);
}
