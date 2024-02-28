using System.Collections.Generic;
using System.Linq;

namespace Mission08_Team0410.Models
{
    public class EFTaskRepository : iTaskRepository
    {
        private Mission08Context _context;

        public EFTaskRepository(Mission08Context context)
        {
            _context = context;
        }

        public List<TaskClass> Tasks => _context.Tasks.ToList();

        public void AddTask(TaskClass task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void UpdateTask(TaskClass task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }

        public void DeleteTask(TaskClass task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }


    }
}
