namespace RichModel.Domain.Enum
{
    public class TaskStatus : Enumeration
    {
        public static readonly TaskStatus Todo = new TaskStatus(1, "Todo");
        public static readonly TaskStatus Doing = new TaskStatus(2, "Doing");
        public static readonly TaskStatus Done = new TaskStatus(3, "Done");

        public TaskStatus(int id, string name) : base(id, name)
        {
        }
    }
}
