namespace LB4
{
    public interface ITodoItem
    {
        int Id { get; }
        string Description { get; }
        bool IsCompleted { get; set; }
    }
}