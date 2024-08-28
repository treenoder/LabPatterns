namespace LB4
{
    // Single Responsibility Principle: Each class has a single responsibility
    public class TodoItem : ITodoItem
    {
        public int Id { get; }
        public string Description { get; }
        public bool IsCompleted { get; set; }

        public TodoItem(int id, string description)
        {
            Id = id;
            Description = description;
            IsCompleted = false;
        }
    }
}