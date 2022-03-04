using RichModel.Domain.Enum;
using RichModel.Domain.Events;
using System;
using System.Collections.Generic;

namespace RichModel.Domain.Entities
{
    public class BacklogItem : Entity
    {
        public BacklogItem(string description)
        {
            Status = BacklogItemStatus.New;
            Description = description;

            Validate();
        }

        public int Id { get; private set; }
        public IList<Task> Tasks { get; private set; }
        public int? SprintId { get; private set; }
        public int? UserId { get; private set; }
        public BacklogItemStatus Status { get; private set; }
        public string Description { get; private set; }
        public DateTime? BeginDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        
        public void SetSprintId(int? sprintId) => SprintId = sprintId;
        public void SetUserId(int? userId) => UserId = userId;
        public void SetStatusToNew() => Status = BacklogItemStatus.New;
        public void SetStatusToCommitted() => Status = BacklogItemStatus.Committed;
        public void SetStatusToApproved() => Status = BacklogItemStatus.Approved;
        public void SetStatusToDone() => Status = BacklogItemStatus.Done;
        public void SetDescription(string description) => Description = description;
        public void SetBeginDate(DateTime? beginDate) => BeginDate = beginDate;
        public void SetEndDate(DateTime? endDate) => BeginDate = endDate;

        public void CommitToSprint(Sprint sprint)
        {
            if (IsCommittedToSprint())
            {
                UncommitFromSprint();
            }

            SetStatusToCommitted();
            SetSprintId(sprint.Id);

            DomainEventPublisher.Publish(new BacklogItemCommitted
            {
                Id = Id,
                SprintId = SprintId.Value
            });
        }
        public void UncommitFromSprint()
        {
            SprintId = null;

            DomainEventPublisher.Publish(new BacklogItemUncommitFromSprint
            {
                Id = Id,
                SprintId = SprintId.Value
            });
        }
        public bool IsCommittedToSprint() => SprintId != null && SprintId != default(int);

        public void Validate()
        {
            if (string.IsNullOrEmpty(Description))
            {
                throw new Exception("Description can not be null");
            }
        }
    }
}