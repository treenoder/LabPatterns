using System.Linq;

namespace LB4
{
    public class TodoApp
    {
        private readonly ITodoService _todoService;
        private readonly IUserInterface _userInterface;

        public TodoApp(ITodoService todoService, IUserInterface userInterface)
        {
            _todoService = todoService;
            _userInterface = userInterface;
        }

        public void Run()
        {
            while (true)
            {
                _userInterface.ShowMessage("\nTodo List:");
                _userInterface.DisplayTodos(_todoService.GetAllTodos());
                _userInterface.ShowMessage("\nCommands: a(dd) <name>, c(omplete) <id>, r(emove) <id>, e(xit)");
                _userInterface.ShowMessage("Enter a command:");

                string input = _userInterface.GetUserInput();
                string[] parts = input.Split(' ');

                switch (parts[0].ToLower())
                {
                    case "a":
                    case "add":
                        if (parts.Length > 1)
                        {
                            _todoService.AddTodo(string.Join(" ", parts.Skip(1)));
                            _userInterface.ShowMessage("Todo added.");
                        }

                        break;
                    case "c":
                    case "complete":
                        if (parts.Length > 1 && int.TryParse(parts[1], out int completeId))
                        {
                            _todoService.MarkAsCompleted(completeId);
                            _userInterface.ShowMessage("Todo marked as completed.");
                        }

                        break;
                    case "r":
                    case "remove":
                        if (parts.Length > 1 && int.TryParse(parts[1], out int removeId))
                        {
                            _todoService.RemoveTodo(removeId);
                            _userInterface.ShowMessage("Todo removed.");
                        }

                        break;
                    case "e":
                    case "exit":
                        return;
                    default:
                        _userInterface.ShowMessage("Invalid command.");
                        break;
                }
            }
        }
    }
}