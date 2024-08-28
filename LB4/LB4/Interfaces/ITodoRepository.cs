using System.Collections.Generic;

namespace LB4
{
    public interface ITodoRepository
    {
        void Add(ITodoItem item);
        void Remove(int id);
        ITodoItem GetById(int id);
        IEnumerable<ITodoItem> GetAll();
    }
}