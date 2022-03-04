namespace AnemicModel.Domain.Services
{
    public interface ISprintServices
    {
        void InsertBacklogItem(int sprintId, int backLogItemId);
    }
}