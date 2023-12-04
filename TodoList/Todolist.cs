class Todolist {

    List<string> Todos = new List<string>();
    
    public void PrintTodos()
    {
       for (int i = 0; i < Todos.Count; i++)
        {
            Console.WriteLine("Task: " + Todos[i]);
        }
    } 
    public void AddTodo() {
        while(true) {
            Console.WriteLine("Add a todo:");

            string Todo = Console.ReadLine();
            if (Todo == "" || Todo == null) {
                continue;
            }
            Todos.Add(Todo);
            break;
        }
    }

} 

