using System.Collections.Generic;
using System.Linq;

namespace LB4
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        private readonly List<ITodoItem> _todos = new List<ITodoItem>();

        public void Add(ITodoItem item) => _todos.Add(item);
        public void Remove(int id) => _todos.RemoveAll(t => t.Id == id);
        public ITodoItem GetById(int id) => _todos.FirstOrDefault(t => t.Id == id);
        public IEnumerable<ITodoItem> GetAll() => _todos;
    }
}