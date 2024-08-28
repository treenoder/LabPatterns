using System.Collections.Generic;

namespace LB4
{
    public interface IUserInterface
    {
        void DisplayTodos(IEnumerable<ITodoItem> todos);
        string GetUserInput();
        void ShowMessage(string message);
    }
}