using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstModel
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public double? Height { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }

        public int SId { get; set; }
        public School School { get; set; }
    }
}
