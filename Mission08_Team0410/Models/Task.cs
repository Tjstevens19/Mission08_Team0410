namespace Mission08_Team0410.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public string Quadrant { get; set; }
        public int CategoryId { get; set; }
        public bool Completed { get; set; }
    }
}