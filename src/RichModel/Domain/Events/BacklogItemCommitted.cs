namespace RichModel.Domain.Events
{
    public class BacklogItemCommitted
    {
        public int Id { get; set; }
        public int SprintId { get; set; }
    }
}
