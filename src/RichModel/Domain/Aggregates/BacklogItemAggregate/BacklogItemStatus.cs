namespace RichModel.Domain.Enum
{
    public class BacklogItemStatus : Enumeration
    {
        public static readonly BacklogItemStatus New = new BacklogItemStatus(1, "New");
        public static readonly BacklogItemStatus Approved = new BacklogItemStatus(2, "Approved");
        public static readonly BacklogItemStatus Committed = new BacklogItemStatus(3, "Committed");
        public static readonly BacklogItemStatus Done = new BacklogItemStatus(4, "Done");

        public BacklogItemStatus(int id, string name) : base(id, name)
        {
        }
    }
}
