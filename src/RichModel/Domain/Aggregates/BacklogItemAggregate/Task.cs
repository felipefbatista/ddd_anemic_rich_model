using RichModel.Domain.Enum;
using System;

namespace RichModel.Domain.Entities
{
    public class Task : Entity
    {
        public Task(int backlogitemId, string description)
        {
            BacklogitemId = backlogitemId;
            Status = TaskStatus.Todo;
            Description = description;
        }

        public int Id { get; private set; }
        public int BacklogitemId { get; private set; }
        public int? UserId { get; private set; }
        public TaskStatus Status { get; private set; }
        public string Description { get; private set; }
        public DateTime? BeginDate { get; private set; }
        public DateTime? EndDate { get; private set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Description))
            {
                throw new Exception("Description can not be null");
            }
        }
    }
}