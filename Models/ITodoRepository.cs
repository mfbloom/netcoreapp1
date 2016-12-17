using System.Collections.Generic;

namespace WebAPIApplication.Models
{
    public interface ITodoRepository
    {
        void Add(TodoItem item);
        IEnumerable<TodoItem> GetAll();
        TodoItem Find(string key);
        TodoItem Remove(string key);
        void Update(TodoItem item);
        void AddSum(TodoItem item);
    }
}
