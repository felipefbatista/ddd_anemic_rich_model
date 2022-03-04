using RichModel.Application;
using RichModel.Infrastructure.Database;
using RichModel.Infrastructure.Repositories;
using System;

namespace RichModel
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryDatabase.Seed();

            IBoardApplication sprintServices = new BoardApplication(new SprintRepository(), new BacklogItemRepository());

            sprintServices.ToAllocateBacklogItemToaSprint(1, 1);

            Console.WriteLine("Hello World!");
        }
    }
}