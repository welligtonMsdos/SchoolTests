using SchoolAPI.Data.Model;
using SchoolTests.Interfaces;

namespace SchoolTests.Builder;

public class ProfessorBuilder : IBuilder<Professor>
{
    private Professor obj;

    public ProfessorBuilder()
    {
        Build();
    }

    public int Id => 1;

    public void Build()
    {
        obj = new Professor(Id, "Girafales", true);
    }

    public int Delete() => Id;

    public async Task<Professor> Get()
    {
        obj.Id = Id;
        return obj;
    }

    public async Task<ICollection<Professor>> GetAll()
    {
        ICollection<Professor> professor = new List<Professor>();
        professor.Add(obj);

        return professor;
    }

    public Professor GetObj()
    {
        return obj;
    }

    public Professor Post() => obj;

    public Professor Put()
    {
        obj.Id = Id;
        return obj;
    }
}
