using AnemicModel.Domain.Entities;
using AnemicModel.Domain.Repositories;
using AnemicModel.Infrastructure.Database;
using System.Linq;

namespace AnemicModel.Infrastructure.Repositories
{
    public class SprintRepository : ISprintRepository
    {
        public void Delete(Sprint entity)
        {
            var item = MemoryDatabase.SprintTable.FirstOrDefault(x => x.Id == entity.Id);
            MemoryDatabase.SprintTable.Remove(item);
        }

        public Sprint GetById(int id)
        {
            return MemoryDatabase.SprintTable.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Sprint entity)
        {
            MemoryDatabase.SprintTableAutoIncrement++;

            entity.Id = MemoryDatabase.SprintTableAutoIncrement;

            MemoryDatabase.SprintTable.Add(entity);
        }

        public void Update(Sprint entity)
        {
            var item = MemoryDatabase.SprintTable.FirstOrDefault(x => x.Id == entity.Id);

            item.Status = entity.Status;
            item.Description = entity.Description;
            item.BeginDate = entity.BeginDate;
            item.EndDate = entity.EndDate;
        }
    }
}