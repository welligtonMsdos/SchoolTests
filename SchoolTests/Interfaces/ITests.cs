namespace SchoolTests.Interfaces;

public interface ITests
{
    Task<int> GetAll();
    string GetByIdZero();
    Task<bool> GetById();
    string DeleteByIdZero();
    Task<bool> Delete();
    Task<bool> Post();
    Task<bool> Put();
}
