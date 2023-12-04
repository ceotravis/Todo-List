class Todolist {

    List<string> Todos = new List<string>();
    
    public void PrintTodos()
    {
       for (int i = 0; i < Todos.Count; i++)
        {
            Console.WriteLine("Task: " + Todos[i]);
        }
    }
} 