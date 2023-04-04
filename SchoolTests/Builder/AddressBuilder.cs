using SchoolAPI.Data.Model;
using SchoolTests.Interfaces;

namespace SchoolTests.Builder;

public class AddressBuilder : IBuilder<Address>
{
    private Address obj;

    public AddressBuilder()
    {
        Build();
    }

    public int Id => 1;

    public void Build()
    {
        obj = new Address(Id, "03040000", "Rua Getulio Vargas", "1964", "Centro", "Brasilia", "DF");
    }

    public int Delete() => Id;

    public async Task<Address> Get()
    {
        obj.Id = Id;
        return obj;
    }

    public async Task<ICollection<Address>> GetAll()
    {
        ICollection<Address> address = new List<Address>();
        address.Add(obj);

        return address;
    }

    public Address Post() => obj;

    public Address Put()
    {
        obj.Id = Id;
        return obj;
    }
}
