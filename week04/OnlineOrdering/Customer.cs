public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Name { get => _name; }
    public Address Address { get => _address; }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}
