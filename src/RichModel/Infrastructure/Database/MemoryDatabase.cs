using RichModel.Domain.Entities;
using RichModel.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace RichModel.Infrastructure.Database
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

            var backlogItem = new BacklogItem("abc");
            backlogItem.SetStatusToNew();
            backlogItem.SetDescription("Sprint 1");
            backlogItem.SetBeginDate(DateTime.Today);
            backlogItem.SetEndDate(DateTime.Today.AddDays(5));

            PropertyInfo backlogItemprop = backlogItem.GetType().GetProperty("Id");
            if (backlogItemprop != null)
            {
                backlogItemprop.SetValue(backlogItem, BacklogItemTableAutoIncrement, null);
            }

            BacklogItemTable.Add(backlogItem);

            var sprint = new Sprint("Sprint 1", DateTime.Today, DateTime.Today);
            sprint.SetStatus(SprintStatus.New);
            sprint.SetDescription("Create XYZ functionality");

            PropertyInfo sprintprop = sprint.GetType().GetProperty("Id");
            if (sprintprop != null)
            {
                sprintprop.SetValue(sprint, SprintTableAutoIncrement, null);
            }

            SprintTable.Add(sprint);
        }
    }
}
