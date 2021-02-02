using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Id);
            }
        }
    }
}
