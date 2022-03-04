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

            IBoardApplication boardApplication = new BoardApplication(new SprintRepository(), new BacklogItemRepository());

            boardApplication.ToAllocateBacklogItemToaSprint(1, 1);

            Console.WriteLine("@Rich Model@");
        }
    }
}