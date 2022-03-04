using AnemicModel.Domain.Services;
using AnemicModel.Infrastructure.Database;
using AnemicModel.Infrastructure.Repositories;
using System;

namespace AnemicModel
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryDatabase.Seed();

            ISprintServices sprintServices = new SprintServices(new SprintRepository(), new BacklogItemRepository());

            sprintServices.InsertBacklogItem(1, 1);

            Console.WriteLine("@Anemic Model@");
        }
    }
}