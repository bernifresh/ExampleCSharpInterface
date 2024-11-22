using MongoDB.Driver;
using ProgrammingAgainstInterfaces.Entities;
using ProgrammingAgainstInterfaces.Repositories.Interfaces;

namespace ProgrammingAgainstInterfaces.Repositories;

public class ExampleRepository(IMongoDatabase database) : IExampleRepository
{
    private readonly IMongoCollection<ExampleEntity> _collection = database.GetCollection<ExampleEntity>("exampleViewModels");

    public async Task<IEnumerable<ExampleEntity>> GetAllAsync()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }

    public async Task<ExampleEntity> GetByIdAsync(string id)
    {
        return await _collection.Find(entity => entity.Id == id).FirstOrDefaultAsync();
    }

    public async Task AddAsync(ExampleEntity entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(string id, ExampleEntity entity)
    {
        await _collection.ReplaceOneAsync(e => e.Id == id, entity);
    }

    public async Task DeleteAsync(string id)
    {
        await _collection.DeleteOneAsync(e => e.Id == id);
    }
}