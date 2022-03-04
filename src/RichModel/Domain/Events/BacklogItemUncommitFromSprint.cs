namespace RichModel.Domain.Events
{
    public class BacklogItemUncommitFromSprint
    {
        public int Id { get; set; }
        public int SprintId { get; set; }
    }
}
