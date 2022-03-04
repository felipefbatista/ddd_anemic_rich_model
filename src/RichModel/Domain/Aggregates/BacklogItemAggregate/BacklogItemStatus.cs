namespace RichModel.Domain.Enum
{
    //Complex enumeration class, allows overload
    public abstract class BacklogItemStatus : Enumeration
    {
        public static readonly BacklogItemStatus New = new BacklogItemStatusNew();
        public static readonly BacklogItemStatus Approved = new BacklogItemStatusApproved();
        public static readonly BacklogItemStatus Committed = new BacklogItemStatusCommitted();
        public static readonly BacklogItemStatus Done = new BacklogItemStatusDone();

        protected BacklogItemStatus(int id, string name) : base(id, name)
        {
        }

        private class BacklogItemStatusNew : BacklogItemStatus
        {
            public BacklogItemStatusNew() : base(1, "New") { }
        }

        private class BacklogItemStatusApproved : BacklogItemStatus
        {
            public BacklogItemStatusApproved() : base(2, "Approved") { }
        }

        private class BacklogItemStatusCommitted : BacklogItemStatus
        {
            public BacklogItemStatusCommitted() : base(3, "Committed") { }
        }

        private class BacklogItemStatusDone : BacklogItemStatus
        {
            public BacklogItemStatusDone() : base(4, "Done") { }
        }
    }
}