using System;
public interface ICustomerRepository
{
    string FindCustomerById(int id);
}

public class CustomerRepositoryImpl : ICustomerRepository
{
    public string FindCustomerById(int id)
    {
        return $"Customer #{id}: John Doe";
    }
}

public class CustomerService
{
    private readonly ICustomerRepository customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        this.customerRepository = customerRepository;
    }

    public void ShowCustomer(int id)
    {
        string customer = customerRepository.FindCustomerById(id);
        Console.WriteLine("Customer Info: " + customer);
    }
}


class Program
{
    static void Main(string[] args)
    {
        ICustomerRepository repository = new CustomerRepositoryImpl();
        CustomerService service = new CustomerService(repository);

        service.ShowCustomer(101);
    }
}
