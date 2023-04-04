using SchoolAPI.Data.Model;
using SchoolTests.Interfaces;

namespace SchoolTests.Builder;

public class GradesBuilder : IBuilder<Grades>
{
    private Grades obj;

    public GradesBuilder()
    {
        Build();
    }
    public int Id => 1;

    public void Build()
    {
        obj = new Grades(Id, 10, 10, 10, 10, 1, 1);
    }

    public int Delete() => Id;

    public async Task<Grades> Get()
    {
        obj.Id = Id;
        return obj;
    }

    public async Task<ICollection<Grades>> GetAll()
    {
        ICollection<Grades> grades = new List<Grades>();
        grades.Add(obj);

        return grades;
    }

    public Grades Post() => obj;    

    public Grades Put()
    {
        obj.Id = Id;
        return obj;
    }
}
