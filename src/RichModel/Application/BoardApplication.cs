using RichModel.Domain.Repositories;

namespace RichModel.Application
{
    public class BoardApplication : IBoardApplication
    {
        private readonly ISprintRepository _sprintRepository;
        private readonly IBacklogItemRepository _backlogItemRepository;
        public BoardApplication(ISprintRepository sprintRepository, IBacklogItemRepository backlogItemRepository)
        {
            _sprintRepository = sprintRepository;
            _backlogItemRepository = backlogItemRepository;
        }

        public void ToAllocateBacklogItemToaSprint(int sprintId, int backLogItemId)
        {
            var sprint = _sprintRepository.GetById(sprintId);
            var backLogItem = _backlogItemRepository.GetById(backLogItemId);

            backLogItem.CommitToSprint(sprint);

            _backlogItemRepository.Update(backLogItem);
        }
    }
}
