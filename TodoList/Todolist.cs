class Todolist
{

    List<string> Todos = new List<string>();
    List<string> TodosDescription = new List<string>();

    public void AddTodo()
    {
        while (true)
        {
            Console.WriteLine("Add a todo:");

            string Todo = Console.ReadLine();
            if (Todo == "" || Todo == null)
            {
                continue;
            }
            Todos.Add(Todo);

            Console.WriteLine("Add a description:");

            string TodoDescription = Console.ReadLine();
            if (TodoDescription == "" || TodoDescription == null)
            {
                Console.WriteLine("You need to add a description");
                continue;
            }
            TodosDescription.Add(TodoDescription);

            break;
        }
    }

    public void PrintTodos() {
        for (int i = 0; i < Todos.Count; i++) {
            Console.WriteLine("Task: " + Todos[i]);
        }
    }

}

