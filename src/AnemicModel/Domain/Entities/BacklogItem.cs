using AnemicModel.Domain.Enum;
using System;
using System.Collections.Generic;

namespace AnemicModel.Domain.Entities
{
    public class BacklogItem
    {
        public int Id { get; set; }
        public IList<Task> Tasks { get; set; }
        public int? SprintId { get; set; }
        public int? UserId { get; set; }
        public BacklogItemStatusEnum Status { get; set; }
        public string Description { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}