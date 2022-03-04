using RichModel.Domain.Entities;
using RichModel.Domain.Repositories;
using RichModel.Infrastructure.Database;
using System.Linq;
using System.Reflection;

namespace RichModel.Infrastructure.Repositories
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

            PropertyInfo prop = entity.GetType().GetProperty("Id");
            if (prop != null)
            {
                prop.SetValue(entity, MemoryDatabase.BacklogItemTableAutoIncrement, null);
            }

            MemoryDatabase.BacklogItemTable.Add(entity);
        }

        public void Update(BacklogItem entity)
        {
            var item = MemoryDatabase.BacklogItemTable.FirstOrDefault(x => x.Id == entity.Id);

            item.SetSprintId(entity?.SprintId);
            item.SetUserId(entity?.UserId);
            item.SetStatusToNew();
            item.SetDescription(entity.Description);
            item.SetBeginDate(entity?.BeginDate);
            item.SetEndDate(entity?.EndDate);
        }
    }
}