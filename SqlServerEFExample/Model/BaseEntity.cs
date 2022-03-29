using System.ComponentModel.DataAnnotations;

namespace SqlServerEFExample.Model
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
