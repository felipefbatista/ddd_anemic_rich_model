using AnemicModel.Domain.Entities;
using AnemicModel.Domain.Enum;
using System;
using System.Collections.Generic;

namespace AnemicModel.Infrastructure.Database
{
    public static class MemoryDatabase
    {
        public static int BacklogItemTableAutoIncrement = 0;
        public static IList<BacklogItem> BacklogItemTable = new List<BacklogItem>();

        public static int SprintTableAutoIncrement = 0;
        public static IList<Sprint> SprintTable = new List<Sprint>();

        public static void Seed()
        {
            BacklogItemTableAutoIncrement++;
            SprintTableAutoIncrement++;

            BacklogItemTable.Add(new BacklogItem
            {
                Id = BacklogItemTableAutoIncrement,
                Status = BacklogItemStatusEnum.New,
                Description = "Sprint 1",
                BeginDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(5)
            });

            SprintTable.Add(new Sprint
            {
                Id = SprintTableAutoIncrement,
                Status = SprintStatusEnum.New,
                Description = "Create XYZ functionality"
            });
        }
    }
}
