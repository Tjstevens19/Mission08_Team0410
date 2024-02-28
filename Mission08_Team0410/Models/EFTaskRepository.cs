using SQLitePCL;

namespace Mission08_Team0410.Models
{
    public class EFTaskRepository : iTaskRepository
    {
        private Mission08Context _context;
        public EFTaskRepository(Mission08Context temp) 
        {
            _context = temp;
        }
        public List<Task> Tasks => _context.Tasks.ToList();

        public void AddTask(Task task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }
    }
}
