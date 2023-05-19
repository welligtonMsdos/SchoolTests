using Moq;
using SchoolAPI.Business.Services;
using SchoolAPI.Data.Repository;
using SchoolTests.Builder;
using SchoolTests.Interfaces;

namespace SchoolTests.Business;

public class StudentBusiness: ITests
{
    private StudentService service;
    private StudentBuilder builder;
    public StudentBusiness()
    {
        service = new StudentService(new Mock<IStudentRepository>().Object);
        builder = new StudentBuilder();
    }

    public async Task<bool> Delete() => await service.Delete(builder.Delete());

    public string DeleteByIdZero() => service.Delete(0).Exception.InnerException.Message;

    public async Task<int> GetAll()
    {
        var obj = builder.GetAll();

        var repository = new Mock<IStudentRepository>();

        repository.Setup(x => x.GetAll()).Returns(obj);

        service = new StudentService(repository.Object);

        return service.GetAll().Result.Count;
    }

    public async Task<bool> GetById()
    {
        var obj = builder.Get();

        var repository = new Mock<IStudentRepository>();

        repository.Setup(x => x.GetById(obj.Id)).Returns(obj);

        service = new StudentService(repository.Object);

        return service.GetById(obj.Result.Id).Id > 0;
    }

    public string GetByIdZero() => service.GetById(0).Exception.InnerException.Message;

    public Task<bool> Post() => service.Post(builder.Post());

    public Task<bool> Put() => service.Put(builder.Put());
}
