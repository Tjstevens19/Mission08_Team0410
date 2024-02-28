using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0410.Models
{
    public class TaskClass
    {
        public int TaskId { get; set; }
        [Required]
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Completed { get; set; }
    }
}