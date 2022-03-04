using AnemicModel.Domain.Enum;
using System;

namespace AnemicModel.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public int BacklogitemId { get; set; }
        public int? UserId { get; set; }
        public TaskStatusEnum Status { get; set; }
        public string Description { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}