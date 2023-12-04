class Program {
    public static void Main(String[] args) {
        Todolist todolist = new Todolist();

        todolist.AddTodo();
        todolist.AddTodo();

        todolist.PrintTodos();

        todolist.PrintTodoDescription();
    }
}