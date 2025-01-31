public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name { get => name; }
    public Address Address { get => address; }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}
