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

        public List<CoveyTask> Tasks => _context.Tasks.ToList();
        public List<Category> Categories => _context.Categories.ToList();

       public void AddTask(CoveyTask task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void UpdateTask(CoveyTask task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }

        public void DeleteTask(CoveyTask task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }


    }
}
