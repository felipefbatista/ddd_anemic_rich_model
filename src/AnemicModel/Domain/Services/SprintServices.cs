using AnemicModel.Domain.Enum;
using AnemicModel.Domain.Repositories;
using AnemicModel.Infrastructure;

namespace AnemicModel.Domain.Services
{
    public class SprintServices : ISprintServices
    {
        private readonly ISprintRepository _sprintRepository;
        private readonly IBacklogItemRepository _backlogItemRepository;
        public SprintServices(ISprintRepository sprintRepository, IBacklogItemRepository backlogItemRepository)
        {
            _sprintRepository = sprintRepository;
            _backlogItemRepository = backlogItemRepository;
        }

        public void InsertBacklogItem(int sprintId, int backLogItemId)
        {
            var sprint = _sprintRepository.GetById(sprintId);
            var backLogItem = _backlogItemRepository.GetById(backLogItemId);

            backLogItem.SprintId = sprintId;
            backLogItem.Status = BacklogItemStatusEnum.Committed;

            EmailService.SendMail("destination@email.com",
                $"The backlog item '{backLogItem.Description}' was assigned to Sprint '{sprint.Description}'");

            _backlogItemRepository.Update(backLogItem);
        }
    }
}