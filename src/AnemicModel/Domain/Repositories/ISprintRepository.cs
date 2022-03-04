using AnemicModel.Domain.Entities;

namespace AnemicModel.Domain.Repositories
{
    public interface ISprintRepository
    {
        Sprint GetById(int id);

        void Insert(Sprint entity);

        void Update(Sprint entity);

        void Delete(Sprint entity);
    }
}