using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0410.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Completed { get; set; }
    }
}