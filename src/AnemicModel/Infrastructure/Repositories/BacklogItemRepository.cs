using AnemicModel.Domain.Entities;
using AnemicModel.Domain.Repositories;
using AnemicModel.Infrastructure.Database;
using System.Linq;

namespace AnemicModel.Infrastructure.Repositories
{
    public class BacklogItemRepository : IBacklogItemRepository
    {        
        public void Delete(BacklogItem entity)
        {
            var item = MemoryDatabase.BacklogItemTable.FirstOrDefault(x => x.Id == entity.Id);
            MemoryDatabase.BacklogItemTable.Remove(item);
        }

        public BacklogItem GetById(int id)
        {
            return MemoryDatabase.BacklogItemTable.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(BacklogItem entity)
        {
            MemoryDatabase.BacklogItemTableAutoIncrement++;

            entity.Id = MemoryDatabase.BacklogItemTableAutoIncrement;

            MemoryDatabase.BacklogItemTable.Add(entity);
        }

        public void Update(BacklogItem entity)
        {
            var item = MemoryDatabase.BacklogItemTable.FirstOrDefault(x => x.Id == entity.Id);

            item.SprintId = entity.SprintId;
            item.UserId = entity.UserId;
            item.Status = entity.Status;
            item.Description = entity.Description;
            item.BeginDate = entity.BeginDate;
            item.EndDate = entity.EndDate;
        }
    }
}