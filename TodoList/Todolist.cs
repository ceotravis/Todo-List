class Todolist
{

    List<string> Todos = new List<string>();
    List<string> TodosDescription = new List<string>();

    public Todolist() {
        // The user needs to have at least one todo to perfrom other actions
        AddTodo();

        while (true) {
            Console.WriteLine("What do you want to do?\n 1. Add a todo\n 2. Show the description of a todo\n 3. Print all todos");
            
            if(Int32.TryParse(Console.ReadLine(), out int Select)) {
                if (Select == 1) {
                    AddTodo();
                    continue;
                } else if (Select == 2) {
                    PrintTodoDescription();
                    continue;
                } else if (Select == 3) {
                    PrintTodos();
                } else {
                    Console.WriteLine("Cannot parse, chose one of the following options");
                    continue;
                }
            }
        }
    }

    public void AddTodo()
    {
        while (true)
        {
            Console.WriteLine("Add a todo:");

            string Todo = Console.ReadLine()!;
            if (Todo == "" || Todo == null)
            {
                continue;
            }
            Todos.Add(Todo);

            Console.WriteLine("Add a description:");

            string TodoDescription = Console.ReadLine()!;
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
            Console.WriteLine("Task " + i + ": " + Todos[i]);
        }
    }

    public void PrintTodoDescription() {
        Console.WriteLine("What description would you like to see?");
        while (true) {
            if (Int32.TryParse(Console.ReadLine(), out int Todo)) {
                Console.WriteLine($"Title: {Todos[Todo - 1]}");
                Console.WriteLine($"Description: {TodosDescription[Todo - 1]}");
                Thread.Sleep(300);
                break;
            } else if (Todo > Todos.Count) {
                Console.WriteLine("A todo with that number does not exist");
                continue;
            } else {
                Console.WriteLine("Parse error, please enter a valid number");
                continue;
            }
        }
    }
}

