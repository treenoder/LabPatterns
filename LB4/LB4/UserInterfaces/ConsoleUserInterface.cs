using System;
using System.Collections.Generic;

namespace LB4
{
    public class ConsoleUserInterface : IUserInterface
    {
        public void DisplayTodos(IEnumerable<ITodoItem> todos)
        {
            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Id}. [{(todo.IsCompleted ? "X" : " ")}] {todo.Description}");
            }
        }

        public string GetUserInput() => Console.ReadLine();

        public void ShowMessage(string message) => Console.WriteLine(message);
    }
}