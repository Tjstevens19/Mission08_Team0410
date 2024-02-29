namespace Mission08_Team0410.Models
{
    public interface iTaskRepository
    {
        List<Task> Tasks { get; }
        List<Category> Categories { get; }
        public void AddTask(Task task);
        public void UpdateTask(Task task);
        public void DeleteTask(Task task);

    }
}