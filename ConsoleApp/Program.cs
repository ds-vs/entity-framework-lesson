using ConsoleApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var persons = context.Persons.Include(p => p.Address).Include(p => p.Department);

                foreach (var person in persons)
                {
                    Console.WriteLine($"{person.Name}, {person.Surname}, " +
                        $"{person.Address?.Street}, {person.Department?.Name}");
                }
            }

            Console.WriteLine("----------------------------------------------------");

            using (var context = new AppDbContext())
            {
                var persons = context.Persons
                    .Join(context.Departments, p => p.Id, d => d.Id,
                    (person, department) => new
                    {
                        Name = person.Name,
                        Department = department.Name
                    });

                foreach (var person in persons)
                {
                    Console.WriteLine($"{person.Name}, {person.Department}");
                }
            }

            Console.WriteLine("----------------------------------------------------");

            using (var context = new AppDbContext())
            {
                var persons = from p in context.Persons
                              join d in context.Departments
                              on p.Id equals d.Id
                              select new
                              {
                                  Name = p.Name,
                                  Department = d.Name
                              };

                foreach (var person in persons)
                {
                    Console.WriteLine($"{person.Name}, {person.Department}");
                }
            }
        }
    }
}