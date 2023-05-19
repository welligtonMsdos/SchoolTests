using SchoolAPI.Data.Model;
using SchoolTests.Interfaces;

namespace SchoolTests.Builder;

public class StudentBuilder : IBuilder<Student>
{
    private Student obj;

    public StudentBuilder()
    {
        Build();
    }
    public int Id => 1;

    public void Build()
    {
        obj = new Student(Id, "Welligton", "D3386E9", "well2023", "well2023", 1, true);
    }

    public int Delete() => Id;

    public async Task<Student> Get()
    {
        obj.Id = Id;
        return obj;
    }

    public async Task<ICollection<Student>> GetAll()
    {
        ICollection<Student> student = new List<Student>();
        student.Add(obj);

        return student;
    }

    public Student Post() => obj;

    public Student Put()
    {
        obj.Id = Id;
        return obj;
    }
}
