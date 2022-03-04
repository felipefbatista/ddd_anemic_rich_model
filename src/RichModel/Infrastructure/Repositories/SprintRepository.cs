using RichModel.Domain.Entities;
using RichModel.Domain.Repositories;
using RichModel.Infrastructure.Database;
using System.Linq;
using System.Reflection;

namespace RichModel.Infrastructure.Repositories
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

            PropertyInfo prop = entity.GetType().GetProperty("Id");
            if (prop != null)
            {
                prop.SetValue(entity, MemoryDatabase.SprintTableAutoIncrement, null);
            }

            MemoryDatabase.SprintTable.Add(entity);
        }

        public void Update(Sprint entity)
        {
            var item = MemoryDatabase.SprintTable.FirstOrDefault(x => x.Id == entity.Id);

            item.SetStatus(entity.Status);
            item.SetDescription(entity.Description);
            item.SetBeginDate(entity.BeginDate);
            item.SetEndDate(entity.EndDate);
        }
    }
}