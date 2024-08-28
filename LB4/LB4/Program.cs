namespace LB4
{
    // Single Responsibility Principle: Each class has a single responsibility
    // Open/Closed Principle: Open for extension, closed for modification
    // Liskov Substitution Principle: Subtypes must be substitutable for their base types
    // Interface Segregation Principle: Clients should not be forced to depend on methods they do not use
    // Dependency Inversion Principle: High-level modules should not depend on low-level modules. Both should depend on abstractions.

    public class Program
    {
        public static void Main(string[] args)
        {
            ITodoRepository repository = new InMemoryTodoRepository();
            ITodoService todoService = new TodoService(repository);
            IUserInterface userInterface = new ConsoleUserInterface();

            var app = new TodoApp(todoService, userInterface);
            app.Run();
        }
    }
}