using ProgrammingAgainstInterfaces.Entities;

namespace ProgrammingAgainstInterfaces.Repositories.Interfaces;

public interface IExampleRepository
{
    IEnumerable<ExampleEntity> GetAll();
    Task<ExampleEntity> GetByIdAsync(string id);
    Task AddAsync(ExampleEntity entity);
    Task UpdateAsync(string id, ExampleEntity entity);
    Task DeleteAsync(string id);
}