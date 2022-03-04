using RichModel.Domain.Enum;
using System;
using System.Collections.Generic;

namespace RichModel.Domain.Entities
{
    public class Sprint : Entity
    {
        public Sprint(string description, DateTime beginDate, DateTime endDate)
        {
            Status = SprintStatus.New;
            Description = description;
            BeginDate = beginDate;
            EndDate = endDate;

            Validate();
        }

        public int Id { get; private set; }
        public IList<BacklogItem> BacklogItems { get; private set; }
        public SprintStatus Status { get; private set; }
        public string Description { get; private set; }
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public void SetStatus(SprintStatus status) => Status = status;
        public void SetDescription(string description) => Description = description;
        public void SetBeginDate(DateTime beginDate) => BeginDate = beginDate;
        public void SetEndDate(DateTime endDate) => BeginDate = endDate;

        public void Validate()
        {
            if (string.IsNullOrEmpty(Description))
            {
                throw new Exception("Description can not be null");
            }

            if (BeginDate > EndDate)
            {
                throw new Exception("EndDate must be greater than BeginDate");
            }
        }
    }
}