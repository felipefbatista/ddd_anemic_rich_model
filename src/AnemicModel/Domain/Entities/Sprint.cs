using AnemicModel.Domain.Enum;
using System;
using System.Collections.Generic;

namespace AnemicModel.Domain.Entities
{
    public class Sprint
    {
        public int Id { get; set; }
        public IList<BacklogItem> BacklogItems { get; set; }
        public SprintStatusEnum Status { get; set; }
        public string Description { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}