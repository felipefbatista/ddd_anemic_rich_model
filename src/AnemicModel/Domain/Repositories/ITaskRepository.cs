using AnemicModel.Domain.Entities;

namespace AnemicModel.Domain.Repositories
{
    public interface ITaskRepository
    {
        Task GetById(int id);

        void Insert(Task entity);

        void Update(Task entity);

        void Delete(Task entity);
    }
}