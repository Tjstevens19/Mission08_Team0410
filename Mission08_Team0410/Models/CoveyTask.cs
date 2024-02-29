using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0410.Models
{
    public class CoveyTask
    {
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public bool Completed { get; set; }
    }
}