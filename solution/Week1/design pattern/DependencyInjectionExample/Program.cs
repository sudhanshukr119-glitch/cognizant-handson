using DependencyInjectionExample.Repositories;
using DependencyInjectionExample.Services;

var service = new CustomerService(new CustomerRepositoryImpl());

service.PrintCustomer(1);
service.PrintCustomer(3);
service.PrintCustomer(99);
