using System.Collections.Generic;

namespace LB4
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;
        private int _nextId = 1;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public void AddTodo(string description)
        {
            var newTodo = new TodoItem(_nextId++, description);
            _repository.Add(newTodo);
        }

        public void MarkAsCompleted(int id)
        {
            var todo = _repository.GetById(id);
            if (todo != null)
            {
                todo.IsCompleted = true;
            }
        }

        public void RemoveTodo(int id)
        {
            _repository.Remove(id);
        }

        public IEnumerable<ITodoItem> GetAllTodos()
        {
            return _repository.GetAll();
        }
    }
}