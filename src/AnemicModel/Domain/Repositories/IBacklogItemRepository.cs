using AnemicModel.Domain.Entities;

namespace AnemicModel.Domain.Repositories
{
    public interface IBacklogItemRepository
    {
        BacklogItem GetById(int id);

        void Insert(BacklogItem entity);

        void Update(BacklogItem entity);

        void Delete(BacklogItem entity);
    }
}