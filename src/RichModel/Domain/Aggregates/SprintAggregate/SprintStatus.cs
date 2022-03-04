namespace RichModel.Domain.Enum
{
    public class SprintStatus : Enumeration
    {
        public static readonly SprintStatus New = new SprintStatus(1, "New");
        public static readonly SprintStatus InExecution = new SprintStatus(2, "InExecution");
        public static readonly SprintStatus Closed = new SprintStatus(3, "Closed");

        public SprintStatus(int id, string name) : base(id, name)
        {
        }
    }
}
