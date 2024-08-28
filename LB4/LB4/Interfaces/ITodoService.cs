using System.Collections.Generic;

namespace LB4
{
    public interface ITodoService
    {
        void AddTodo(string description);
        void MarkAsCompleted(int id);
        void RemoveTodo(int id);
        IEnumerable<ITodoItem> GetAllTodos();
    }
}