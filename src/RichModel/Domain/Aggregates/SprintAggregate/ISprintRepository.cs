using RichModel.Domain.Entities;

namespace RichModel.Domain.Repositories
{
    public interface ISprintRepository
    {
        Sprint GetById(int id);

        void Insert(Sprint entity);

        void Update(Sprint entity);

        void Delete(Sprint entity);
    }
}