﻿namespace ConsoleApp.Entity
{
    public class Hobby
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}
