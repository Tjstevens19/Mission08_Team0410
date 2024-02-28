namespace Mission08_Team0410.Models
{
    public class iTaskRepository
    {
        List<Task> Tasks { get; }
        public void AddTask(Task task);
    }
}
