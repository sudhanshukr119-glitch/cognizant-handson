using DependencyInjectionExample.Repositories;

namespace DependencyInjectionExample.Services;

public class CustomerService
{
    private readonly ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repository) =>
        _repository = repository;

    public void PrintCustomer(int id)
    {
        var customer = _repository.FindCustomerById(id);
        Console.WriteLine(customer is not null
            ? $"Found: ID={customer.Id}, Name={customer.Name}"
            : $"Customer with ID={id} not found.");
    }
}
