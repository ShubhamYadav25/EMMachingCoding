using System.ComponentModel.DataAnnotations.Schema;

namespace EMMachingCoding.Domain
{
    [Table("employee")]
    public class Employee
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Column("email")]

        public string Email { get; set; } = string.Empty;
        [Column("department")]

        public string Department { get; set; } = string.Empty;
        [Column("salary")]
        public decimal Salary { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
