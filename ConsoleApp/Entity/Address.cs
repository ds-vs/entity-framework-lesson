using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Entity
{
    public class Address
    {
        [Key]
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public string? Street { get; set; }

        public Person Person { get; set; }
    }
}
