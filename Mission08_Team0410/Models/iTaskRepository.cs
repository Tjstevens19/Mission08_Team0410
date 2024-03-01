namespace Mission08_Team0410.Models
{
    public interface iTaskRepository
    {
        List<CoveyTask> Tasks { get; }
        List<Category> Categories { get; }
        public void AddTask(CoveyTask task);
        public void UpdateTask(CoveyTask task);
        public void DeleteTask(CoveyTask task);
        CoveyTask GetTaskById(int taskId);

    }
}