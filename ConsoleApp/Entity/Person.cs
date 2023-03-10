using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MiddleName { get; set; }
        public string? Surname { get; set; }

        public Department? Department { get; set; }
        public Address? Address { get; set; }

        public ICollection<Hobby> Hobbies { get; set; }
    }
}
