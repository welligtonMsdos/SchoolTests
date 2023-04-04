using Moq;
using SchoolAPI.Business.Enum;
using SchoolAPI.Business.Services;
using SchoolAPI.Data.Repository;
using SchoolTests.Business;
using SchoolTests.Interfaces;

namespace SchoolTests.Services;

public class AddressServiceTests
{
    private readonly ITests _tests;
    private AddressService service;

    public AddressServiceTests()
    {
        _tests = new AddressBusiness();
        service = new AddressService(new Mock<IAddressRepository>().Object);
    }

    [Fact]
    public void GetAll() => Assert.True(_tests.GetAll().Result > 0);

    [Fact]
    public void GetById() => Assert.True(_tests.GetById().Result);

    [Fact]
    public void GetByIdZero() => Assert.Equal(Messages.ID_CANNOT_BE_RESET, _tests.GetByIdZero().ToString());

    [Fact]
    public void Post() => Assert.True(_tests.Post().Result);

    [Fact]
    public void Put() => Assert.True(_tests.Put().Result);

    [Fact]
    public void Delete() => Assert.True(_tests.Delete().Result);

    [Fact]
    public void DeleteByIdZero() => Assert.Equal(Messages.ID_CANNOT_BE_RESET, _tests.DeleteByIdZero());
}
